// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using Azure.Messaging.EventGrid;

namespace EventGridSubscription
{
    public static class EventGridSubscription
    {
        [FunctionName("func-eventgrid-subscription")]
        public static void Run([EventGridTrigger]EventGridEvent eventGridEvent, ILogger log)
        {
            log.LogInformation("func-eventgrid-subscription start");
            log.LogInformation(eventGridEvent.Data.ToString());
        }
    }
}
