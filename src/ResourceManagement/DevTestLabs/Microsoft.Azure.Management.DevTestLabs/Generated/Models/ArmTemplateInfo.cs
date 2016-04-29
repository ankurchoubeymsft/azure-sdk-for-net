// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class ArmTemplateInfo
    {
        /// <summary>
        /// Initializes a new instance of the ArmTemplateInfo class.
        /// </summary>
        public ArmTemplateInfo() { }

        /// <summary>
        /// Initializes a new instance of the ArmTemplateInfo class.
        /// </summary>
        public ArmTemplateInfo(string template = default(string), string parameters = default(string))
        {
            Template = template;
            Parameters = parameters;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public string Template { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

    }
}