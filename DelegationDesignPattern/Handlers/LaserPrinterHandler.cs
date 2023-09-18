using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegationDesignPattern.Common;

namespace DelegationDesignPattern.Handlers
{
    public class LaserPrinterHandler : IPrinterHandler
    {
        public PrinterType Type => PrinterType.Laser;

        public void Print(string document)
        {
            Console.WriteLine($"Printing {document} using Laser printer");
        }
    }
}
