// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Server response for GetMemberGroups API call. </summary>
    public partial class UserGetMemberGroupsResult
    {
        /// <summary> Initializes a new instance of UserGetMemberGroupsResult. </summary>
        internal UserGetMemberGroupsResult()
        {
        }

        /// <summary> Initializes a new instance of UserGetMemberGroupsResult. </summary>
        /// <param name="value"> A collection of group IDs of which the user is a member. </param>
        internal UserGetMemberGroupsResult(IReadOnlyList<string> value)
        {
            Value = value;
        }

        /// <summary> A collection of group IDs of which the user is a member. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}