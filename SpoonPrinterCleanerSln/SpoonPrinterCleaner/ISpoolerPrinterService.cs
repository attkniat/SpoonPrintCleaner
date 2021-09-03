using System;
using System.Collections.Generic;
using System.Text;

namespace SpoonPrinterCleaner.SpoonPrinterInterfaces
{
    public interface ISpoolerPrinterService
    {
        void StarStopSpoonServicePrinter(); 
        void ClearQueuePrinter();
    }
}