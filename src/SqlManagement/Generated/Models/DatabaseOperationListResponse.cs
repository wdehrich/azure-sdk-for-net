// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Response containing the list of database operations for a given server
    /// or database.
    /// </summary>
    public partial class DatabaseOperationListResponse : OperationResponse, IEnumerable<DatabaseOperationListResponse.DatabaseOperation>
    {
        private IList<DatabaseOperationListResponse.DatabaseOperation> _databaseOperations;
        
        /// <summary>
        /// Gets or sets the list of database operations' response.
        /// </summary>
        public IList<DatabaseOperationListResponse.DatabaseOperation> DatabaseOperations
        {
            get { return this._databaseOperations; }
            set { this._databaseOperations = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseOperationListResponse
        /// class.
        /// </summary>
        public DatabaseOperationListResponse()
        {
            this._databaseOperations = new List<DatabaseOperationListResponse.DatabaseOperation>();
        }
        
        /// <summary>
        /// Gets the sequence of DatabaseOperations.
        /// </summary>
        public IEnumerator<DatabaseOperationListResponse.DatabaseOperation> GetEnumerator()
        {
            return this.DatabaseOperations.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of DatabaseOperations.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Database operation.
        /// </summary>
        public partial class DatabaseOperation
        {
            private string _databaseName;
            
            /// <summary>
            /// Gets or sets the name of the SQL Database on which the
            /// operation is performed.
            /// </summary>
            public string DatabaseName
            {
                get { return this._databaseName; }
                set { this._databaseName = value; }
            }
            
            private string _error;
            
            /// <summary>
            /// Gets or sets the description of the error that occurred during
            /// a failed operation.
            /// </summary>
            public string Error
            {
                get { return this._error; }
                set { this._error = value; }
            }
            
            private int _errorCode;
            
            /// <summary>
            /// Gets or sets the code indicating the error that occurred during
            /// a failed operation.
            /// </summary>
            public int ErrorCode
            {
                get { return this._errorCode; }
                set { this._errorCode = value; }
            }
            
            private int _errorSeverity;
            
            /// <summary>
            /// Gets or sets the severity level of the error that occurred
            /// during a failed operation.
            /// </summary>
            public int ErrorSeverity
            {
                get { return this._errorSeverity; }
                set { this._errorSeverity = value; }
            }
            
            private int _errorState;
            
            /// <summary>
            /// Gets or sets the error state.
            /// </summary>
            public int ErrorState
            {
                get { return this._errorState; }
                set { this._errorState = value; }
            }
            
            private string _id;
            
            /// <summary>
            /// Gets or sets unique identifier of the operation..
            /// </summary>
            public string Id
            {
                get { return this._id; }
                set { this._id = value; }
            }
            
            private DateTime _lastModifyTime;
            
            /// <summary>
            /// Gets or sets the timestamp when the record was last modified
            /// for a long running operation.
            /// </summary>
            public DateTime LastModifyTime
            {
                get { return this._lastModifyTime; }
                set { this._lastModifyTime = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Gets or sets the name of the operation.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _parentLink;
            
            /// <summary>
            /// Gets or sets the ParentLink of the operation.
            /// </summary>
            public string ParentLink
            {
                get { return this._parentLink; }
                set { this._parentLink = value; }
            }
            
            private int _percentComplete;
            
            /// <summary>
            /// Gets or sets the percentage of operation that has completed.
            /// </summary>
            public int PercentComplete
            {
                get { return this._percentComplete; }
                set { this._percentComplete = value; }
            }
            
            private string _selfLink;
            
            /// <summary>
            /// Gets or sets the SelfLink of the operation.
            /// </summary>
            public string SelfLink
            {
                get { return this._selfLink; }
                set { this._selfLink = value; }
            }
            
            private string _sessionActivityId;
            
            /// <summary>
            /// Gets or sets session scoped ID of the operation.
            /// </summary>
            public string SessionActivityId
            {
                get { return this._sessionActivityId; }
                set { this._sessionActivityId = value; }
            }
            
            private DateTime _startTime;
            
            /// <summary>
            /// Gets or sets the timestamp when the operation started.
            /// </summary>
            public DateTime StartTime
            {
                get { return this._startTime; }
                set { this._startTime = value; }
            }
            
            private string _state;
            
            /// <summary>
            /// Gets or sets the state of the operation.
            /// </summary>
            public string State
            {
                get { return this._state; }
                set { this._state = value; }
            }
            
            private int _stateId;
            
            /// <summary>
            /// Gets or sets current state of the long running operation in
            /// numeric format.
            /// </summary>
            public int StateId
            {
                get { return this._stateId; }
                set { this._stateId = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Gets or sets the type of resource.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the DatabaseOperation class.
            /// </summary>
            public DatabaseOperation()
            {
            }
        }
    }
}
