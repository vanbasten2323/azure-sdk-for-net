// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Operation status extended info for ILR provision action.
    /// </summary>
    public partial class OperationStatusProvisionILRExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationStatusProvisionILRExtendedInfo class.
        /// </summary>
        public OperationStatusProvisionILRExtendedInfo() { }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationStatusProvisionILRExtendedInfo class.
        /// </summary>
        /// <param name="recoveryTarget">Target details for file / folder
        /// restore.</param>
        public OperationStatusProvisionILRExtendedInfo(InstantItemRecoveryTarget recoveryTarget = default(InstantItemRecoveryTarget))
        {
            RecoveryTarget = recoveryTarget;
        }

        /// <summary>
        /// Gets or sets target details for file / folder restore.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryTarget")]
        public InstantItemRecoveryTarget RecoveryTarget { get; set; }

    }
}
