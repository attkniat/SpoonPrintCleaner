using SpoonPrinterCleaner.SpoonPrinterInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace SpoonPrinterCleaner.SpoonPrinterServices
{
    public class SpoolerPrinterService : ISpoolerPrinterService
    {
        public void ClearQueuePrinter()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\System32\spool\PRINTERS");
            if (dir.Exists)
            {
                foreach (var fileQueue in dir.GetFiles())
                {
                    fileQueue.Delete();
                }
            }
        }

        public void StarStopSpoonServicePrinter()
        {
            ServiceController sc = new ServiceController("Spooler");

            Console.WriteLine("The Spooler service status is currently set to {0}",
                  sc.Status.ToString());

            if ((sc.Status.Equals(ServiceControllerStatus.Stopped)) ||
                 (sc.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                Console.WriteLine("Starting the Spooler service...");
                sc.Start();
            }
            else
            {
                Console.WriteLine("Stopping the Spooler service...");
                sc.Stop();
            }

            sc.Refresh();
            Console.WriteLine("The Spooler service status is now set to {0}.", sc.Status.ToString());
        }
    }
}