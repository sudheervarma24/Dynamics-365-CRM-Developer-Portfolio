using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
namespace ASK1026Plugin
{
    public class ASK1026PopulateFullName : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the tracing service
            ITracingService tracingService =
            (ITracingService)serviceProvider.GetService(typeof(ITracingService));
// Obtain the execution context from the service provider.  
            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));
// The InputParameters collection contains all the data passed in the message request.  
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                // Obtain the target entity from the input parameters.  
                Entity sourceRecordInfo = (Entity)context.InputParameters["Target"];//Varaible name change here entity to sourceRecordInfo
// Obtain the IOrganizationService instance which you will need for  
                // web service calls.  
                IOrganizationServiceFactory serviceFactory =
                    (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
try
                {
                    string firstName = "";
                    string lastName = "";
//--String or single line of text - get syntax for C#
                    if (sourceRecordInfo.Contains("sud_firstname") && sourceRecordInfo["sud_firstname"] != null)
                    {
                        firstName = sourceRecordInfo["sud_firstname"].ToString();
                    }
if (sourceRecordInfo.Contains("sud_lastname") && sourceRecordInfo["sud_lastname"] != null)
                    {
                        lastName = sourceRecordInfo["sud_lastname"].ToString();
                    }
string fullName = firstName + " " + lastName;//red marks came firstname and lastname dont come out from if statements so at top declare, remove declare string under if statement.
//--single line of text - set syntax
                    sourceRecordInfo["sud_name"] = fullName;
}
catch (Exception ex)
                {
                    tracingService.Trace("ASK1026PopulateFullName Plugin: {0}", ex.ToString());
                    throw;
                }
            }
}
    }
}
