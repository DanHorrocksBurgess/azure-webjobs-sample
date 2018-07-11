using System;
using Microsoft.Azure.WebJobs;

namespace azure_webjob_sample.functions
{
    public class SampleTimerFunction
    {
        public static void CronJob([TimerTrigger("*/20 * * * * *")] TimerInfo timerInfo)
        {
            Console.WriteLine("Timer fired!");
        }
    }
}