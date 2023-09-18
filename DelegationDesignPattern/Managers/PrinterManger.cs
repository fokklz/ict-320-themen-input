using DelegationDesignPattern.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDesignPattern.Managers
{
    /// <summary>
    /// The Core class for this showcase of the Delegation Design Pattern
    /// 
    /// The class accepts a "Print" function which is delegated 
    /// to the appropriate handler, based on the printer type
    /// </summary>
    public class PrinterManger
    {
        private readonly Dictionary<PrinterType, IPrinterHandler> _printerHandlers = 
            new Dictionary<PrinterType, IPrinterHandler>();

        public void RegisterHandler(IPrinterHandler printerHandler)
        {
            _printerHandlers[printerHandler.Type] = printerHandler;
        }

        public void Print(string document, PrinterType type)
        {
            if (_printerHandlers.ContainsKey(type))
            {
                _printerHandlers[type].Print(document);
            }
            else
            {
                Console.WriteLine($"No handler for printer type: {type}");
            }
        }

        public IEnumerable<PrinterType> GetRegisteredPrinterTypes()
        {
            return _printerHandlers.Keys;
        }

    }
}
