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
using System.Linq;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// Azure SQL workload-specific extended protected item info class.
    /// </summary>
    public partial class AzureSqlProtectedItemExtendedInfo : ProtectedItemExtendedInfo
    {
        private System.DateTime? _oldestRecoveryPoint;
        
        /// <summary>
        /// Optional. The oldest recovery point persisted for this protected
        /// item in the service.
        /// </summary>
        public System.DateTime? OldestRecoveryPoint
        {
            get { return this._oldestRecoveryPoint; }
            set { this._oldestRecoveryPoint = value; }
        }
        
        private string _policyState;
        
        /// <summary>
        /// Optional. State of the protection policy associated with this
        /// protected item.
        /// </summary>
        public string PolicyState
        {
            get { return this._policyState; }
            set { this._policyState = value; }
        }
        
        private int? _recoveryPointCount;
        
        /// <summary>
        /// Optional. Number of recovery points persisted for this protected
        /// item in the service.
        /// </summary>
        public int? RecoveryPointCount
        {
            get { return this._recoveryPointCount; }
            set { this._recoveryPointCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureSqlProtectedItemExtendedInfo
        /// class.
        /// </summary>
        public AzureSqlProtectedItemExtendedInfo()
        {
        }
    }
}