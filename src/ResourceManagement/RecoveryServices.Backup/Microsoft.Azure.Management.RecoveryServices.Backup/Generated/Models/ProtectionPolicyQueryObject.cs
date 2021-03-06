// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Filters the list backup policies API.
    /// </summary>
    public partial class ProtectionPolicyQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionPolicyQueryObject
        /// class.
        /// </summary>
        public ProtectionPolicyQueryObject() { }

        /// <summary>
        /// Initializes a new instance of the ProtectionPolicyQueryObject
        /// class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for the
        /// backup policy. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        public ProtectionPolicyQueryObject(BackupManagementType? backupManagementType = default(BackupManagementType?))
        {
            BackupManagementType = backupManagementType;
        }

        /// <summary>
        /// Gets or sets backup management type for the backup policy.
        /// Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

    }
}
