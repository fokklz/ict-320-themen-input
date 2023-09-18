using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDesignPattern.Common
{
    public enum PrinterType
    {
        Laser,
        Inkjet
    }

    public interface IPrinterHandler
    {
        PrinterType Type { get; }

        void Print(string document);

    }
}
