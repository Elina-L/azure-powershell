// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;
    using System;

    /// <summary>Creates or updates subscription diagnostic settings for the specified resource.</summary>
    /// <remarks>
    /// [OpenAPI] CreateOrUpdate=>PUT:"/subscriptions/{subscriptionId}/providers/Microsoft.Insights/diagnosticSettings/{name}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"AzSubscriptionDiagnosticSetting_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Description(@"Creates or updates subscription diagnostic settings for the specified resource.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Generated]
    public partial class NewAzSubscriptionDiagnosticSetting_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>The subscription diagnostic setting resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource _parametersBody = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.SubscriptionDiagnosticSettingsResource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.DiagnosticSetting Client => Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>The resource Id for the event hub authorization rule.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource Id for the event hub authorization rule.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource Id for the event hub authorization rule.",
        SerializedName = @"eventHubAuthorizationRuleId",
        PossibleTypes = new [] { typeof(string) })]
        public string EventHubAuthorizationRuleId { get => _parametersBody.EventHubAuthorizationRuleId ?? null; set => _parametersBody.EventHubAuthorizationRuleId = value; }

        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The name of the event hub. If none is specified, the default event hub will be selected.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the event hub. If none is specified, the default event hub will be selected.",
        SerializedName = @"eventHubName",
        PossibleTypes = new [] { typeof(string) })]
        public string EventHubName { get => _parametersBody.EventHubName ?? null; set => _parametersBody.EventHubName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>The list of logs settings.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of logs settings.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of logs settings.",
        SerializedName = @"logs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionLogSettings) })]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionLogSettings[] Log { get => _parametersBody.Log ?? null /* arrayOf */; set => _parametersBody.Log = value; }

        /// <summary>
        /// The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full ARM resource ID of the Marketplace resource to which you would like to send Diagnostic Logs.",
        SerializedName = @"marketplacePartnerId",
        PossibleTypes = new [] { typeof(string) })]
        public string MarketplacePartnerId { get => _parametersBody.MarketplacePartnerId ?? null; set => _parametersBody.MarketplacePartnerId = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the diagnostic setting.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the diagnostic setting.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the diagnostic setting.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.",
        SerializedName = @"serviceBusRuleId",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceBusRuleId { get => _parametersBody.ServiceBusRuleId ?? null; set => _parametersBody.ServiceBusRuleId = value; }

        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource ID of the storage account to which you would like to send Diagnostic Logs.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the storage account to which you would like to send Diagnostic Logs.",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        public string StorageAccountId { get => _parametersBody.StorageAccountId ?? null; set => _parametersBody.StorageAccountId = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Category(global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        public string WorkspaceId { get => _parametersBody.WorkspaceId ?? null; set => _parametersBody.WorkspaceId = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource">Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data.Message, new string[]{});
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewAzSubscriptionDiagnosticSetting_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewAzSubscriptionDiagnosticSetting_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'SubscriptionDiagnosticSettingsCreateOrUpdate' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.SubscriptionDiagnosticSettingsCreateOrUpdate(SubscriptionId, Name, _parametersBody, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  SubscriptionId=SubscriptionId,Name=Name,body=_parametersBody})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20150401.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, Name=Name, body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId=SubscriptionId, Name=Name, body=_parametersBody })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource">Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource
                WriteObject((await response));
            }
        }
    }
}