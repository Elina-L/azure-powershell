﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Sql.Common;
using Microsoft.Azure.Commands.Sql.OutboundFirewallRules.Model;
using Microsoft.Azure.Commands.Sql.OutboundFirewallRules.Services;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.OutboundFirewallRules.Cmdlet
{
    public abstract class AzureSqlServerOutboundFirewallRulesCmdletBase : AzureSqlCmdletBase<IEnumerable<AzureSqlServerOutboundFirewallRulesModel>, AzureSqlServerOutboundFirewallRulesAdapter>
    {
        /// <summary>
        /// Gets or sets the name of the Azure Sql Server to use
        /// </summary>
        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 1,
            HelpMessage = "The Azure Sql Server Outbound Firewall Rule name.")]
        [ResourceNameCompleter("Microsoft.Sql/servers", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string ServerName { get; set; }

        /// <summary>
        /// Initializes the model adapter
        /// </summary>
        /// <returns>The server adapter</returns>
        protected override AzureSqlServerOutboundFirewallRulesAdapter InitModelAdapter()
        {
            return new AzureSqlServerOutboundFirewallRulesAdapter(DefaultProfile.DefaultContext);
        }
    }
}
