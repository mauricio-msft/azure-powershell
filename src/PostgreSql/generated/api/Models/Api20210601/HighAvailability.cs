namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>High availability properties of a server</summary>
    public partial class HighAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal
    {

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Backing field for <see cref="Mode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? _mode;

        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? Mode { get => this._mode; set => this._mode = value; }

        /// <summary>Backing field for <see cref="StandbyAvailabilityZone" /> property.</summary>
        private string _standbyAvailabilityZone;

        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string StandbyAvailabilityZone { get => this._standbyAvailabilityZone; set => this._standbyAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? _state;

        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? State { get => this._state; }

        /// <summary>Creates an new <see cref="HighAvailability" /> instance.</summary>
        public HighAvailability()
        {

        }
    }
    /// High availability properties of a server
    public partial interface IHighAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The HA mode for the server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? Mode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability zone information of the standby.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string StandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a HA server that is visible to user.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? State { get;  }

    }
    /// High availability properties of a server
    internal partial interface IHighAvailabilityInternal

    {
        /// <summary>The HA mode for the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? Mode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        string StandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? State { get; set; }

    }
}