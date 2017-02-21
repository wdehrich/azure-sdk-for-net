// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The workflow output parameter.
    /// </summary>
    public partial class WorkflowOutputParameter : WorkflowParameter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowOutputParameter class.
        /// </summary>
        public WorkflowOutputParameter() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowOutputParameter class.
        /// </summary>
        public WorkflowOutputParameter(ParameterType? type = default(ParameterType?), object value = default(object), object metadata = default(object), string description = default(string), object error = default(object))
            : base(type, value, metadata, description)
        {
            Error = error;
        }

        /// <summary>
        /// Gets gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public object Error { get; private set; }

    }
}
