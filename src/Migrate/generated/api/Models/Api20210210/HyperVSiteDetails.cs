namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>HyperVSite fabric specific details.</summary>
    public partial class HyperVSiteDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVSiteDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVSiteDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails __fabricSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FabricSpecificDetails();

        /// <summary>Backing field for <see cref="HyperVHost" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails[] _hyperVHost;

        /// <summary>The list of Hyper-V hosts associated with the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails[] HyperVHost { get => this._hyperVHost; set => this._hyperVHost = value; }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal)__fabricSpecificDetails).InstanceType = value; }

        /// <summary>Creates an new <see cref="HyperVSiteDetails" /> instance.</summary>
        public HyperVSiteDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fabricSpecificDetails), __fabricSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__fabricSpecificDetails), __fabricSpecificDetails);
        }
    }
    /// HyperVSite fabric specific details.
    public partial interface IHyperVSiteDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetails
    {
        /// <summary>The list of Hyper-V hosts associated with the fabric.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of Hyper-V hosts associated with the fabric.",
        SerializedName = @"hyperVHosts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails[] HyperVHost { get; set; }

    }
    /// HyperVSite fabric specific details.
    internal partial interface IHyperVSiteDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificDetailsInternal
    {
        /// <summary>The list of Hyper-V hosts associated with the fabric.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails[] HyperVHost { get; set; }

    }
}