using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctiom_timer
{
    public static class Function1
    {

        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer,  
            [ Queue("theeque", Connection= "AzureWebsStorage")] out string QMessage, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now.ToLongTimeString()}");
            QMessage = "Timmer triggered";
        }
    }
}
