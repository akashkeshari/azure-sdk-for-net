﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary>
    /// </summary>
    internal class ExtractPagesOperation : Operation<IReadOnlyList<ExtractedPage>>
    {
        private Response _response;
        private IReadOnlyList<ExtractedPage> _value;
        private bool _hasCompleted;

        private readonly string _modelId;
        private readonly ServiceClient _operations;

        public override string Id { get; }

        public override IReadOnlyList<ExtractedPage> Value => OperationHelpers.GetValue(ref _value);

        public override bool HasCompleted => _hasCompleted;

        public override bool HasValue => _value != null;

        /// <inheritdoc/>
        public override Response GetRawResponse() => _response;

        /// <inheritdoc/>
        public override ValueTask<Response<IReadOnlyList<ExtractedPage>>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            this.DefaultWaitForCompletionAsync(cancellationToken);

        /// <inheritdoc/>
        public override ValueTask<Response<IReadOnlyList<ExtractedPage>>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) =>
            this.DefaultWaitForCompletionAsync(pollingInterval, cancellationToken);

        /// <summary>
        /// </summary>
        /// <param name="operations"></param>
        /// <param name="modelId"></param>
        /// <param name="operationLocation"></param>
        internal ExtractPagesOperation(ServiceClient operations, string modelId, string operationLocation)
        {
            _operations = operations;
            _modelId = modelId;

            // TODO: Add validation here
            // https://github.com/Azure/azure-sdk-for-net/issues/10385
            Id = operationLocation.Split('/').Last();
        }

        /// <inheritdoc/>
        public override Response UpdateStatus(CancellationToken cancellationToken = default) =>
            UpdateStatusAsync(false, cancellationToken).EnsureCompleted();

        /// <inheritdoc/>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) =>
            await UpdateStatusAsync(true, cancellationToken).ConfigureAwait(false);

        private async ValueTask<Response> UpdateStatusAsync(bool async, CancellationToken cancellationToken)
        {
            if (!_hasCompleted)
            {
                Response<AnalyzeOperationResult_internal> update = async
                    ? await _operations.GetAnalyzeFormResultAsync(new Guid(_modelId), new Guid(Id), cancellationToken).ConfigureAwait(false)
                    : _operations.GetAnalyzeFormResult(new Guid(_modelId), new Guid(Id), cancellationToken);

                // TODO: Handle correctly according to returned status code
                // https://github.com/Azure/azure-sdk-for-net/issues/10386
                // TODO: Add reasonable null checks.

                if (update.Value.Status == OperationStatus.Succeeded || update.Value.Status == OperationStatus.Failed)
                {
                    _hasCompleted = true;
                    _value = ConvertToExtractedPages(update.Value.AnalyzeResult.PageResults, update.Value.AnalyzeResult.ReadResults);
                }

                _response = update.GetRawResponse();
            }

            return GetRawResponse();
        }

        private static IReadOnlyList<ExtractedPage> ConvertToExtractedPages(IReadOnlyList<PageResult_internal> pageResults, IReadOnlyList<ReadResult_internal> readResults)
        {
            List<ExtractedPage> pages = new List<ExtractedPage>();
            for (int i = 0; i < pageResults.Count; i++)
            {
                pages.Add(new ExtractedPage(pageResults[i], readResults[i]));
            }
            return pages;
        }
    }
}
