// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class EstimatedVMPrice
    {
        internal static EstimatedVMPrice DeserializeEstimatedVMPrice(JsonElement element)
        {
            double retailPrice = default;
            VMPriceOSType osType = default;
            VMTier vmTier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retailPrice"))
                {
                    retailPrice = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = new VMPriceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmTier"))
                {
                    vmTier = new VMTier(property.Value.GetString());
                    continue;
                }
            }
            return new EstimatedVMPrice(retailPrice, osType, vmTier);
        }
    }
}
