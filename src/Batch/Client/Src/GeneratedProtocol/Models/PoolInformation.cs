// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies how a job should be assigned to a pool.
    /// </summary>
    public partial class PoolInformation
    {
        /// <summary>
        /// Initializes a new instance of the PoolInformation class.
        /// </summary>
        public PoolInformation() { }

        /// <summary>
        /// Initializes a new instance of the PoolInformation class.
        /// </summary>
        /// <param name="poolId">The ID of an existing pool. All the tasks of
        /// the job will run on the specified pool.</param>
        /// <param name="autoPoolSpecification">Characteristics for a temporary
        /// 'auto pool'. The Batch service will create this auto pool when the
        /// job is submitted.</param>
        public PoolInformation(string poolId = default(string), AutoPoolSpecification autoPoolSpecification = default(AutoPoolSpecification))
        {
            PoolId = poolId;
            AutoPoolSpecification = autoPoolSpecification;
        }

        /// <summary>
        /// Gets or sets the ID of an existing pool. All the tasks of the job
        /// will run on the specified pool.
        /// </summary>
        /// <remarks>
        /// You must ensure that the pool referenced by this property exists.
        /// If the pool does not exist at the time the Batch service tries to
        /// schedule a job, no tasks for the job will run until you create a
        /// pool with that id. Note that the Batch service will not reject the
        /// job request; it will simply not run tasks until the pool exists.
        /// You must specify either the pool ID or the auto pool specification,
        /// but not both.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets characteristics for a temporary 'auto pool'. The Batch
        /// service will create this auto pool when the job is submitted.
        /// </summary>
        /// <remarks>
        /// If auto pool creation fails, the Batch service moves the job to a
        /// completed state, and the pool creation error is set in the job's
        /// scheduling error property. The Batch service manages the lifetime
        /// (both creation and, unless keepAlive is specified, deletion) of the
        /// auto pool. Any user actions that affect the lifetime of the auto
        /// pool while the job is active will result in unexpected behavior.
        /// You must specify either the pool ID or the auto pool specification,
        /// but not both.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoPoolSpecification")]
        public AutoPoolSpecification AutoPoolSpecification { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AutoPoolSpecification != null)
            {
                this.AutoPoolSpecification.Validate();
            }
        }
    }
}
