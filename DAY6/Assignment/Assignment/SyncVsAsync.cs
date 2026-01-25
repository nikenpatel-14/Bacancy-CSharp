using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Assignment
{
    internal class SyncVsAsync
    {
        static async  Task AsyncapiCall()
        {
            Console.WriteLine("Aync api");
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(1000);
           
           

        }
        static void SyncApicall()
        {
            Console.WriteLine("Sync Api");
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            Task.Delay(1000).Wait();
           
            

        }
        static async Task Main()
        {

            //synchronus execution
            Stopwatch syncw = Stopwatch.StartNew();
            SyncApicall();
            SyncApicall();
            syncw.Stop();
            Console.WriteLine("sync api call time" + syncw.ElapsedMilliseconds + "ms");


            //asynchronus execution
            Stopwatch asyncw = Stopwatch.StartNew();

            //to execute Concurrently
            Task t1 = AsyncapiCall();
            Task t2 = AsyncapiCall();
            await t1;
            await t2;

            // sequential await
            //await AsyncapiCall();
            //await AsyncapiCall();

            asyncw.Stop();
            Console.WriteLine("async api call time" + asyncw.ElapsedMilliseconds + "ms");



            // for logs using concurrent bag
            var logs = new ConcurrentBag<string>();
           
            Stopwatch logswatch = Stopwatch.StartNew();
            Task t3 = AsyncApiCallForLogs(logs);
            Task t4 = AsyncApiCallForLogs(logs);
            await Task.WhenAll(t3, t4);// wait for all task to complete
            logswatch.Stop();

            foreach (var log in logs) {
                Console.WriteLine(log);
            }
            Console.WriteLine("total time : " + logswatch.ElapsedMilliseconds + "ms");
        }

        // passing concurrentbag for logs
        static async Task AsyncApiCallForLogs(ConcurrentBag<string> logs)
        {
            logs.Add($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(1000); 

            
        }

    }
}
