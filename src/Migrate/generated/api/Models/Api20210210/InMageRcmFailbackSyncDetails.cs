namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcmFailback disk level sync details.</summary>
    public partial class InMageRcmFailbackSyncDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal
    {

        /// <summary>Backing field for <see cref="Last15MinutesTransferredByte" /> property.</summary>
        private long? _last15MinutesTransferredByte;

        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? Last15MinutesTransferredByte { get => this._last15MinutesTransferredByte; }

        /// <summary>Backing field for <see cref="LastDataTransferTimeUtc" /> property.</summary>
        private string _lastDataTransferTimeUtc;

        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LastDataTransferTimeUtc { get => this._lastDataTransferTimeUtc; }

        /// <summary>Backing field for <see cref="LastRefreshTime" /> property.</summary>
        private string _lastRefreshTime;

        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LastRefreshTime { get => this._lastRefreshTime; }

        /// <summary>Internal Acessors for Last15MinutesTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.Last15MinutesTransferredByte { get => this._last15MinutesTransferredByte; set { {_last15MinutesTransferredByte = value;} } }

        /// <summary>Internal Acessors for LastDataTransferTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.LastDataTransferTimeUtc { get => this._lastDataTransferTimeUtc; set { {_lastDataTransferTimeUtc = value;} } }

        /// <summary>Internal Acessors for LastRefreshTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.LastRefreshTime { get => this._lastRefreshTime; set { {_lastRefreshTime = value;} } }

        /// <summary>Internal Acessors for ProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.ProcessedByte { get => this._processedByte; set { {_processedByte = value;} } }

        /// <summary>Internal Acessors for ProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.ProgressHealth { get => this._progressHealth; set { {_progressHealth = value;} } }

        /// <summary>Internal Acessors for ProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.ProgressPercentage { get => this._progressPercentage; set { {_progressPercentage = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for TransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal.TransferredByte { get => this._transferredByte; set { {_transferredByte = value;} } }

        /// <summary>Backing field for <see cref="ProcessedByte" /> property.</summary>
        private long? _processedByte;

        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ProcessedByte { get => this._processedByte; }

        /// <summary>Backing field for <see cref="ProgressHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? _progressHealth;

        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ProgressHealth { get => this._progressHealth; }

        /// <summary>Backing field for <see cref="ProgressPercentage" /> property.</summary>
        private int? _progressPercentage;

        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ProgressPercentage { get => this._progressPercentage; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="TransferredByte" /> property.</summary>
        private long? _transferredByte;

        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? TransferredByte { get => this._transferredByte; }

        /// <summary>Creates an new <see cref="InMageRcmFailbackSyncDetails" /> instance.</summary>
        public InMageRcmFailbackSyncDetails()
        {

        }
    }
    /// InMageRcmFailback disk level sync details.
    public partial interface IInMageRcmFailbackSyncDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The bytes transferred in last 15 minutes from source VM to target.",
        SerializedName = @"last15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? Last15MinutesTransferredByte { get;  }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last data transfer from source VM to target.",
        SerializedName = @"lastDataTransferTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string LastDataTransferTimeUtc { get;  }
        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last refresh time.",
        SerializedName = @"lastRefreshTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastRefreshTime { get;  }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.",
        SerializedName = @"processedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ProcessedByte { get;  }
        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The progress health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ProgressHealth { get;  }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress in percentage. Progress percentage is calculated based on processed bytes.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressPercentage { get;  }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get;  }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The transferred bytes from source VM to azure for the disk.",
        SerializedName = @"transferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? TransferredByte { get;  }

    }
    /// InMageRcmFailback disk level sync details.
    internal partial interface IInMageRcmFailbackSyncDetailsInternal

    {
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        long? Last15MinutesTransferredByte { get; set; }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        string LastDataTransferTimeUtc { get; set; }
        /// <summary>The last refresh time.</summary>
        string LastRefreshTime { get; set; }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        long? ProcessedByte { get; set; }
        /// <summary>The progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ProgressHealth { get; set; }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        int? ProgressPercentage { get; set; }
        /// <summary>The start time.</summary>
        string StartTime { get; set; }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        long? TransferredByte { get; set; }

    }
}