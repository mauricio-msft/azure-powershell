namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Existing recovery availability set input.</summary>
    public partial class ExistingRecoveryAvailabilitySet :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingRecoveryAvailabilitySet,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingRecoveryAvailabilitySetInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails __recoveryAvailabilitySetCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetails();

        /// <summary>Backing field for <see cref="RecoveryAvailabilitySetId" /> property.</summary>
        private string _recoveryAvailabilitySetId;

        /// <summary>The recovery availability set Id. Will throw error, if resource does not exist.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAvailabilitySetId { get => this._recoveryAvailabilitySetId; set => this._recoveryAvailabilitySetId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetailsInternal)__recoveryAvailabilitySetCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetailsInternal)__recoveryAvailabilitySetCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="ExistingRecoveryAvailabilitySet" /> instance.</summary>
        public ExistingRecoveryAvailabilitySet()
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
            await eventListener.AssertNotNull(nameof(__recoveryAvailabilitySetCustomDetails), __recoveryAvailabilitySetCustomDetails);
            await eventListener.AssertObjectIsValid(nameof(__recoveryAvailabilitySetCustomDetails), __recoveryAvailabilitySetCustomDetails);
        }
    }
    /// Existing recovery availability set input.
    public partial interface IExistingRecoveryAvailabilitySet :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetails
    {
        /// <summary>The recovery availability set Id. Will throw error, if resource does not exist.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery availability set Id. Will throw error, if resource does not exist.",
        SerializedName = @"recoveryAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilitySetId { get; set; }

    }
    /// Existing recovery availability set input.
    internal partial interface IExistingRecoveryAvailabilitySetInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryAvailabilitySetCustomDetailsInternal
    {
        /// <summary>The recovery availability set Id. Will throw error, if resource does not exist.</summary>
        string RecoveryAvailabilitySetId { get; set; }

    }
}