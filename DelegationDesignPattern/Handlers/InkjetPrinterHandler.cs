using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegationDesignPattern.Common;

namespace DelegationDesignPattern.Handlers
{
    class InkjetPrinterHandler : IPrinterHandler
    {
        public PrinterType Type => PrinterType.Inkjet;

        public void Print(string document)
        {
            Console.WriteLine($"Printing {document} using Inkjet printer");
        }

    }
}
