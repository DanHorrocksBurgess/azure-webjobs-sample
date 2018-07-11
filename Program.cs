using System;
using Microsoft.Azure.WebJobs;

namespace azure_webjob_sample
{
    class Program
    {
        private const string StorageAccountConnectionString =  "STORAGE_CONNECTION_STRING_HERE";
        private const string DashboardConnectionString = "STORAGE_CONNECTION_STRING_HERE";
        
        static void Main(string[] args)
        {
            var config = new JobHostConfiguration
            {
                DashboardConnectionString = DashboardConnectionString,
                StorageConnectionString = StorageAccountConnectionString
            };

            config.UseTimers();
            
            var host = new JobHost(config);

            host.RunAndBlock();
        }
    }
}
