/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.ManagedBlockchain;
using Amazon.ManagedBlockchain.Model;

namespace Amazon.PowerShell.Cmdlets.MBC
{
    /// <summary>
    /// Creates a member within a Managed Blockchain network.
    /// </summary>
    [Cmdlet("New", "MBCMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Managed Blockchain CreateMember API operation.", Operation = new[] {"CreateMember"}, SelectReturnType = typeof(Amazon.ManagedBlockchain.Model.CreateMemberResponse))]
    [AWSCmdletOutput("System.String or Amazon.ManagedBlockchain.Model.CreateMemberResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.ManagedBlockchain.Model.CreateMemberResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewMBCMemberCmdlet : AmazonManagedBlockchainClientCmdlet, IExecutor
    {
        
        #region Parameter Fabric_AdminPassword
        /// <summary>
        /// <para>
        /// <para>The password for the member's initial administrative user. The <code>AdminPassword</code>
        /// must be at least eight characters long and no more than 32 characters. It must contain
        /// at least one uppercase letter, one lowercase letter, and one digit. It cannot have
        /// a single quote(‘), double quote(“), forward slash(/), backward slash(\), @, or a space.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MemberConfiguration_FrameworkConfiguration_Fabric_AdminPassword")]
        public System.String Fabric_AdminPassword { get; set; }
        #endregion
        
        #region Parameter Fabric_AdminUsername
        /// <summary>
        /// <para>
        /// <para>The user name for the member's initial administrative user.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MemberConfiguration_FrameworkConfiguration_Fabric_AdminUsername")]
        public System.String Fabric_AdminUsername { get; set; }
        #endregion
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an AWS SDK or the AWS CLI.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter MemberConfiguration_Description
        /// <summary>
        /// <para>
        /// <para>An optional description of the member.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MemberConfiguration_Description { get; set; }
        #endregion
        
        #region Parameter InvitationId
        /// <summary>
        /// <para>
        /// <para>The unique identifier of the invitation that is sent to the member to join the network.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String InvitationId { get; set; }
        #endregion
        
        #region Parameter MemberConfiguration_Name
        /// <summary>
        /// <para>
        /// <para>The name of the member.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String MemberConfiguration_Name { get; set; }
        #endregion
        
        #region Parameter NetworkId
        /// <summary>
        /// <para>
        /// <para>The unique identifier of the network in which the member is created.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String NetworkId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'MemberId'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ManagedBlockchain.Model.CreateMemberResponse).
        /// Specifying the name of a property of type Amazon.ManagedBlockchain.Model.CreateMemberResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "MemberId";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the MemberConfiguration_Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^MemberConfiguration_Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^MemberConfiguration_Name' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.MemberConfiguration_Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-MBCMember (CreateMember)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ManagedBlockchain.Model.CreateMemberResponse, NewMBCMemberCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.MemberConfiguration_Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientRequestToken = this.ClientRequestToken;
            context.InvitationId = this.InvitationId;
            #if MODULAR
            if (this.InvitationId == null && ParameterWasBound(nameof(this.InvitationId)))
            {
                WriteWarning("You are passing $null as a value for parameter InvitationId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MemberConfiguration_Description = this.MemberConfiguration_Description;
            context.Fabric_AdminPassword = this.Fabric_AdminPassword;
            context.Fabric_AdminUsername = this.Fabric_AdminUsername;
            context.MemberConfiguration_Name = this.MemberConfiguration_Name;
            #if MODULAR
            if (this.MemberConfiguration_Name == null && ParameterWasBound(nameof(this.MemberConfiguration_Name)))
            {
                WriteWarning("You are passing $null as a value for parameter MemberConfiguration_Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NetworkId = this.NetworkId;
            #if MODULAR
            if (this.NetworkId == null && ParameterWasBound(nameof(this.NetworkId)))
            {
                WriteWarning("You are passing $null as a value for parameter NetworkId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.ManagedBlockchain.Model.CreateMemberRequest();
            
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.InvitationId != null)
            {
                request.InvitationId = cmdletContext.InvitationId;
            }
            
             // populate MemberConfiguration
            var requestMemberConfigurationIsNull = true;
            request.MemberConfiguration = new Amazon.ManagedBlockchain.Model.MemberConfiguration();
            System.String requestMemberConfiguration_memberConfiguration_Description = null;
            if (cmdletContext.MemberConfiguration_Description != null)
            {
                requestMemberConfiguration_memberConfiguration_Description = cmdletContext.MemberConfiguration_Description;
            }
            if (requestMemberConfiguration_memberConfiguration_Description != null)
            {
                request.MemberConfiguration.Description = requestMemberConfiguration_memberConfiguration_Description;
                requestMemberConfigurationIsNull = false;
            }
            System.String requestMemberConfiguration_memberConfiguration_Name = null;
            if (cmdletContext.MemberConfiguration_Name != null)
            {
                requestMemberConfiguration_memberConfiguration_Name = cmdletContext.MemberConfiguration_Name;
            }
            if (requestMemberConfiguration_memberConfiguration_Name != null)
            {
                request.MemberConfiguration.Name = requestMemberConfiguration_memberConfiguration_Name;
                requestMemberConfigurationIsNull = false;
            }
            Amazon.ManagedBlockchain.Model.MemberFrameworkConfiguration requestMemberConfiguration_memberConfiguration_FrameworkConfiguration = null;
            
             // populate FrameworkConfiguration
            var requestMemberConfiguration_memberConfiguration_FrameworkConfigurationIsNull = true;
            requestMemberConfiguration_memberConfiguration_FrameworkConfiguration = new Amazon.ManagedBlockchain.Model.MemberFrameworkConfiguration();
            Amazon.ManagedBlockchain.Model.MemberFabricConfiguration requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric = null;
            
             // populate Fabric
            var requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_FabricIsNull = true;
            requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric = new Amazon.ManagedBlockchain.Model.MemberFabricConfiguration();
            System.String requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminPassword = null;
            if (cmdletContext.Fabric_AdminPassword != null)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminPassword = cmdletContext.Fabric_AdminPassword;
            }
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminPassword != null)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric.AdminPassword = requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminPassword;
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_FabricIsNull = false;
            }
            System.String requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminUsername = null;
            if (cmdletContext.Fabric_AdminUsername != null)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminUsername = cmdletContext.Fabric_AdminUsername;
            }
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminUsername != null)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric.AdminUsername = requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric_fabric_AdminUsername;
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_FabricIsNull = false;
            }
             // determine if requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric should be set to null
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_FabricIsNull)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric = null;
            }
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric != null)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration.Fabric = requestMemberConfiguration_memberConfiguration_FrameworkConfiguration_memberConfiguration_FrameworkConfiguration_Fabric;
                requestMemberConfiguration_memberConfiguration_FrameworkConfigurationIsNull = false;
            }
             // determine if requestMemberConfiguration_memberConfiguration_FrameworkConfiguration should be set to null
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfigurationIsNull)
            {
                requestMemberConfiguration_memberConfiguration_FrameworkConfiguration = null;
            }
            if (requestMemberConfiguration_memberConfiguration_FrameworkConfiguration != null)
            {
                request.MemberConfiguration.FrameworkConfiguration = requestMemberConfiguration_memberConfiguration_FrameworkConfiguration;
                requestMemberConfigurationIsNull = false;
            }
             // determine if request.MemberConfiguration should be set to null
            if (requestMemberConfigurationIsNull)
            {
                request.MemberConfiguration = null;
            }
            if (cmdletContext.NetworkId != null)
            {
                request.NetworkId = cmdletContext.NetworkId;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.ManagedBlockchain.Model.CreateMemberResponse CallAWSServiceOperation(IAmazonManagedBlockchain client, Amazon.ManagedBlockchain.Model.CreateMemberRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Managed Blockchain", "CreateMember");
            try
            {
                #if DESKTOP
                return client.CreateMember(request);
                #elif CORECLR
                return client.CreateMemberAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String ClientRequestToken { get; set; }
            public System.String InvitationId { get; set; }
            public System.String MemberConfiguration_Description { get; set; }
            public System.String Fabric_AdminPassword { get; set; }
            public System.String Fabric_AdminUsername { get; set; }
            public System.String MemberConfiguration_Name { get; set; }
            public System.String NetworkId { get; set; }
            public System.Func<Amazon.ManagedBlockchain.Model.CreateMemberResponse, NewMBCMemberCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.MemberId;
        }
        
    }
}