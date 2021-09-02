using SpoonPrinterCleaner.SpoonPrinterInterfaces;
using SpoonPrinterCleaner.SpoonPrinterServices;
using System;

namespace SpoonPrinterCleaner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var service = new SpoolerPrinterService();

            service.StarStopSpoonServicePrinter();
            service.ClearQueuePrinter();
            service.StarStopSpoonServicePrinter();
        }
    }
}