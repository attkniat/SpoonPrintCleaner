using System;
using System.Collections.Generic;
using System.Text;

namespace SpoonPrinterCleaner.SpoonPrinterInterfaces
{
    public interface ISpoolerPrinterService
    {
        void TurnOffSpoonServicePrinter(); 
        void TurnOnSpoonServicePrinter();
        void ClearQueuePrinter();
    }
}