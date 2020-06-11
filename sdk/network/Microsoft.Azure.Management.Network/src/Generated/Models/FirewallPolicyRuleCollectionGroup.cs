// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Rule Collection Group resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FirewallPolicyRuleCollectionGroup : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRuleCollectionGroup
        /// class.
        /// </summary>
        public FirewallPolicyRuleCollectionGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRuleCollectionGroup
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="priority">Priority of the Firewall Policy Rule
        /// Collection Group resource.</param>
        /// <param name="ruleCollections">Group of Firewall Policy rule
        /// collections.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// firewall policy rule collection group resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Rule Group type.</param>
        public FirewallPolicyRuleCollectionGroup(string id = default(string), int? priority = default(int?), IList<FirewallPolicyRuleCollection> ruleCollections = default(IList<FirewallPolicyRuleCollection>), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Priority = priority;
            RuleCollections = ruleCollections;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets priority of the Firewall Policy Rule Collection Group
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets group of Firewall Policy rule collections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleCollections")]
        public IList<FirewallPolicyRuleCollection> RuleCollections { get; set; }

        /// <summary>
        /// Gets the provisioning state of the firewall policy rule collection
        /// group resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets rule Group type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Priority > 65000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 65000);
            }
            if (Priority < 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 100);
            }
            if (RuleCollections != null)
            {
                foreach (var element in RuleCollections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}