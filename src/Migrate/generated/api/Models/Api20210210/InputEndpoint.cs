namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class InputEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInputEndpointInternal
    {

        /// <summary>Backing field for <see cref="EndpointName" /> property.</summary>
        private string _endpointName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EndpointName { get => this._endpointName; set => this._endpointName = value; }

        /// <summary>Backing field for <see cref="PrivatePort" /> property.</summary>
        private int? _privatePort;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? PrivatePort { get => this._privatePort; set => this._privatePort = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Backing field for <see cref="PublicPort" /> property.</summary>
        private int? _publicPort;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? PublicPort { get => this._publicPort; set => this._publicPort = value; }

        /// <summary>Creates an new <see cref="InputEndpoint" /> instance.</summary>
        public InputEndpoint()
        {

        }
    }
    public partial interface IInputEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"endpointName",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"privatePort",
        PossibleTypes = new [] { typeof(int) })]
        int? PrivatePort { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        string Protocol { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"publicPort",
        PossibleTypes = new [] { typeof(int) })]
        int? PublicPort { get; set; }

    }
    internal partial interface IInputEndpointInternal

    {
        string EndpointName { get; set; }

        int? PrivatePort { get; set; }

        string Protocol { get; set; }

        int? PublicPort { get; set; }

    }
}