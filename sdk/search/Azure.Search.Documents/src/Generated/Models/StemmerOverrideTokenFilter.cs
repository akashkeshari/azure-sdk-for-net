// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> Provides the ability to override other stemming filters with custom dictionary-based stemming. Any dictionary-stemmed terms will be marked as keywords so that they will not be stemmed with stemmers down the chain. Must be placed before any stemming filters. This token filter is implemented using Apache Lucene. </summary>
    public partial class StemmerOverrideTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of StemmerOverrideTokenFilter. </summary>
        /// <param name="rules"> A list of stemming rules in the following format: &quot;word =&gt; stem&quot;, for example: &quot;ran =&gt; run&quot;. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public StemmerOverrideTokenFilter(IList<string> rules, string name) : base(name)
        {
            Rules = rules;
            ODataType = "#Microsoft.Azure.Search.StemmerOverrideTokenFilter";
        }

        /// <summary> Initializes a new instance of StemmerOverrideTokenFilter. </summary>
        /// <param name="rules"> A list of stemming rules in the following format: &quot;word =&gt; stem&quot;, for example: &quot;ran =&gt; run&quot;. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal StemmerOverrideTokenFilter(IList<string> rules, string oDataType, string name) : base(oDataType, name)
        {
            Rules = rules;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.StemmerOverrideTokenFilter";
        }

        /// <summary> A list of stemming rules in the following format: &quot;word =&gt; stem&quot;, for example: &quot;ran =&gt; run&quot;. </summary>
        public IList<string> Rules { get; } = new List<string>();
    }
}
