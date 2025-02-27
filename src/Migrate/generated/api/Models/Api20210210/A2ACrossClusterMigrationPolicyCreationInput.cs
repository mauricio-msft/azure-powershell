namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A Cross-Cluster Migration Policy creation input.</summary>
    public partial class A2ACrossClusterMigrationPolicyCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationPolicyCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationPolicyCreationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput __policyProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PolicyProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal)__policyProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="A2ACrossClusterMigrationPolicyCreationInput" /> instance.
        /// </summary>
        public A2ACrossClusterMigrationPolicyCreationInput()
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
            await eventListener.AssertNotNull(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__policyProviderSpecificInput), __policyProviderSpecificInput);
        }
    }
    /// A2A Cross-Cluster Migration Policy creation input.
    public partial interface IA2ACrossClusterMigrationPolicyCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInput
    {

    }
    /// A2A Cross-Cluster Migration Policy creation input.
    internal partial interface IA2ACrossClusterMigrationPolicyCreationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPolicyProviderSpecificInputInternal
    {

    }
}