namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>
    /// This class represents a task which is actually a workflow so that one can navigate to its individual drill down.
    /// </summary>
    public partial class JobTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetails __taskTypeDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TaskTypeDetails();

        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetailsInternal)__taskTypeDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetailsInternal)__taskTypeDetails).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="JobTask" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntity _jobTask;

        /// <summary>The job entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntity JobTask { get => (this._jobTask = this._jobTask ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobEntity()); set => this._jobTask = value; }

        /// <summary>The job display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskJobFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobFriendlyName = value ?? null; }

        /// <summary>The job id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobId = value ?? null; }

        /// <summary>The job name. Enum type ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).JobScenarioName = value ?? null; }

        /// <summary>The workflow affected object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskTargetInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetInstanceType = value ?? null; }

        /// <summary>The object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskTargetObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetObjectId = value ?? null; }

        /// <summary>The object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string JobTaskTargetObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetObjectName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntityInternal)JobTask).TargetObjectName = value ?? null; }

        /// <summary>Internal Acessors for JobTask</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntity Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobTaskDetailsInternal.JobTask { get => (this._jobTask = this._jobTask ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobEntity()); set { {_jobTask = value;} } }

        /// <summary>Creates an new <see cref="JobTaskDetails" /> instance.</summary>
        public JobTaskDetails()
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
            await eventListener.AssertNotNull(nameof(__taskTypeDetails), __taskTypeDetails);
            await eventListener.AssertObjectIsValid(nameof(__taskTypeDetails), __taskTypeDetails);
        }
    }
    /// This class represents a task which is actually a workflow so that one can navigate to its individual drill down.
    public partial interface IJobTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetails
    {
        /// <summary>The job display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The job display name.",
        SerializedName = @"jobFriendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskJobFriendlyName { get; set; }
        /// <summary>The job id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The job id.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskJobId { get; set; }
        /// <summary>The job name. Enum type ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The job name. Enum type ScenarioName.",
        SerializedName = @"jobScenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskJobScenarioName { get; set; }
        /// <summary>The workflow affected object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The workflow affected object type.",
        SerializedName = @"targetInstanceType",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskTargetInstanceType { get; set; }
        /// <summary>The object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object id.",
        SerializedName = @"targetObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskTargetObjectId { get; set; }
        /// <summary>The object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object name.",
        SerializedName = @"targetObjectName",
        PossibleTypes = new [] { typeof(string) })]
        string JobTaskTargetObjectName { get; set; }

    }
    /// This class represents a task which is actually a workflow so that one can navigate to its individual drill down.
    internal partial interface IJobTaskDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITaskTypeDetailsInternal
    {
        /// <summary>The job entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobEntity JobTask { get; set; }
        /// <summary>The job display name.</summary>
        string JobTaskJobFriendlyName { get; set; }
        /// <summary>The job id.</summary>
        string JobTaskJobId { get; set; }
        /// <summary>The job name. Enum type ScenarioName.</summary>
        string JobTaskJobScenarioName { get; set; }
        /// <summary>The workflow affected object type.</summary>
        string JobTaskTargetInstanceType { get; set; }
        /// <summary>The object id.</summary>
        string JobTaskTargetObjectId { get; set; }
        /// <summary>The object name.</summary>
        string JobTaskTargetObjectName { get; set; }

    }
}