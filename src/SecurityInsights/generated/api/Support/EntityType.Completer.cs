// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>The type of the entity</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityTypeTypeConverter))]
    public partial struct EntityType :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Account".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Account'", "Account", global::System.Management.Automation.CompletionResultType.ParameterValue, "Account");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Host".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Host'", "Host", global::System.Management.Automation.CompletionResultType.ParameterValue, "Host");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "File".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'File'", "File", global::System.Management.Automation.CompletionResultType.ParameterValue, "File");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AzureResource".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'AzureResource'", "AzureResource", global::System.Management.Automation.CompletionResultType.ParameterValue, "AzureResource");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CloudApplication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CloudApplication'", "CloudApplication", global::System.Management.Automation.CompletionResultType.ParameterValue, "CloudApplication");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DNS".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DNS'", "DNS", global::System.Management.Automation.CompletionResultType.ParameterValue, "DNS");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "FileHash".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'FileHash'", "FileHash", global::System.Management.Automation.CompletionResultType.ParameterValue, "FileHash");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "IP".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'IP'", "IP", global::System.Management.Automation.CompletionResultType.ParameterValue, "IP");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Malware".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Malware'", "Malware", global::System.Management.Automation.CompletionResultType.ParameterValue, "Malware");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Process".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Process'", "Process", global::System.Management.Automation.CompletionResultType.ParameterValue, "Process");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RegistryKey".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'RegistryKey'", "RegistryKey", global::System.Management.Automation.CompletionResultType.ParameterValue, "RegistryKey");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RegistryValue".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'RegistryValue'", "RegistryValue", global::System.Management.Automation.CompletionResultType.ParameterValue, "RegistryValue");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityGroup".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SecurityGroup'", "SecurityGroup", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityGroup");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "URL".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'URL'", "URL", global::System.Management.Automation.CompletionResultType.ParameterValue, "URL");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "IoTDevice".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'IoTDevice'", "IoTDevice", global::System.Management.Automation.CompletionResultType.ParameterValue, "IoTDevice");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SecurityAlert".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SecurityAlert'", "SecurityAlert", global::System.Management.Automation.CompletionResultType.ParameterValue, "SecurityAlert");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "HuntingBookmark".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'HuntingBookmark'", "HuntingBookmark", global::System.Management.Automation.CompletionResultType.ParameterValue, "HuntingBookmark");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MailCluster".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MailCluster'", "MailCluster", global::System.Management.Automation.CompletionResultType.ParameterValue, "MailCluster");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MailMessage".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'MailMessage'", "MailMessage", global::System.Management.Automation.CompletionResultType.ParameterValue, "MailMessage");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Mailbox".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Mailbox'", "Mailbox", global::System.Management.Automation.CompletionResultType.ParameterValue, "Mailbox");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SubmissionMail".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SubmissionMail'", "SubmissionMail", global::System.Management.Automation.CompletionResultType.ParameterValue, "SubmissionMail");
            }
        }
    }
}