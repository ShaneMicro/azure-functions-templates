using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class BlobTriggerCSharp
    {
        private readonly ILogger<BlobTriggerCSharp> log;

        public BlobTriggerCSharp(ILogger<BlobTriggerCSharp> log)
        {
            this.log = log;            
        }

        [FunctionName("BlobTriggerCSharp")]
        public void Run([BlobTrigger("PathValue/{name}", Connection = "ConnectionValue")]Stream myBlob, string name)
        {
            log.LogInformation($"Test1 C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
