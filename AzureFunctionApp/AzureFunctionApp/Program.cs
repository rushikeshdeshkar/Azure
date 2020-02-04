using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionApp
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}

    public static class QueueFunctions
    {
        //[FunctionName("QueueTrigger")]
        //public static void QueueTrigger(
        //    [QueueTrigger("myqueue-items")] string myQueueItem,
        //    ILogger log)
        //{
        //    log.LogInformation($"C# function processed: {myQueueItem}");
        //}

        [FunctionName("QueueTrigger")]
        public static void Run(
    [QueueTrigger("requestqueue")] string myQueueItem,
    ILogger log)
        {
            log.LogInformation($"C# function processed: {myQueueItem}");
        }
    }
}
