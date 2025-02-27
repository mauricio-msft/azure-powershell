namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Create protection intent input.</summary>
    public partial class CreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateProtectionIntentProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentInputInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProperties _property;

        /// <summary>Create protection intent input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CreateProtectionIntentProperties()); set => this._property = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>Creates an new <see cref="CreateProtectionIntentInput" /> instance.</summary>
        public CreateProtectionIntentInput()
        {

        }
    }
    /// Create protection intent input.
    public partial interface ICreateProtectionIntentInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }

    }
    /// Create protection intent input.
    internal partial interface ICreateProtectionIntentInputInternal

    {
        /// <summary>Create protection intent input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProperties Property { get; set; }
        /// <summary>
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICreateProtectionIntentProviderSpecificDetails ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }

    }
}