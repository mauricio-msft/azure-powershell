namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>HyperV replica Azure input to update replication protected item.</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperVReplicaAzureUpdateReplicationProtectedItemInputTypeConverter))]
    public partial class HyperVReplicaAzureUpdateReplicationProtectedItemInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperVReplicaAzureUpdateReplicationProtectedItemInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperVReplicaAzureUpdateReplicationProtectedItemInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperVReplicaAzureUpdateReplicationProtectedItemInput" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperVReplicaAzureUpdateReplicationProtectedItemInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV1ResourceGroupId = (string) content.GetValueForProperty("RecoveryAzureV1ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV1ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV2ResourceGroupId = (string) content.GetValueForProperty("RecoveryAzureV2ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV2ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).UseManagedDisk = (string) content.GetValueForProperty("UseManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).UseManagedDisk, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).DiskIdToDiskEncryptionMap = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputDiskIdToDiskEncryptionMap) content.GetValueForProperty("DiskIdToDiskEncryptionMap",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).DiskIdToDiskEncryptionMap, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputDiskIdToDiskEncryptionMapTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetVMTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetVmtags) content.GetValueForProperty("TargetVMTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetVMTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetVmtagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetManagedDiskTags) content.GetValueForProperty("TargetManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetNicTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetNicTags) content.GetValueForProperty("TargetNicTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetNicTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetNicTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).SqlServerLicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType?) content.GetValueForProperty("SqlServerLicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).SqlServerLicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperVReplicaAzureUpdateReplicationProtectedItemInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV1ResourceGroupId = (string) content.GetValueForProperty("RecoveryAzureV1ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV1ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV2ResourceGroupId = (string) content.GetValueForProperty("RecoveryAzureV2ResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).RecoveryAzureV2ResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).UseManagedDisk = (string) content.GetValueForProperty("UseManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).UseManagedDisk, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).DiskIdToDiskEncryptionMap = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputDiskIdToDiskEncryptionMap) content.GetValueForProperty("DiskIdToDiskEncryptionMap",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).DiskIdToDiskEncryptionMap, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputDiskIdToDiskEncryptionMapTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetVMTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetVmtags) content.GetValueForProperty("TargetVMTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetVMTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetVmtagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetManagedDiskTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetManagedDiskTags) content.GetValueForProperty("TargetManagedDiskTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetManagedDiskTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetManagedDiskTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetNicTag = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputTargetNicTags) content.GetValueForProperty("TargetNicTag",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).TargetNicTag, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HyperVReplicaAzureUpdateReplicationProtectedItemInputTargetNicTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).SqlServerLicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType?) content.GetValueForProperty("SqlServerLicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureUpdateReplicationProtectedItemInputInternal)this).SqlServerLicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateReplicationProtectedItemProviderInputInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// HyperV replica Azure input to update replication protected item.
    [System.ComponentModel.TypeConverter(typeof(HyperVReplicaAzureUpdateReplicationProtectedItemInputTypeConverter))]
    public partial interface IHyperVReplicaAzureUpdateReplicationProtectedItemInput

    {

    }
}