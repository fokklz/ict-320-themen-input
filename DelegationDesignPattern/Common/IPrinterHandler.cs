using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationDesignPattern.Common
{
    /// <summary>
    /// Interface für einen Druckerhandler
    /// 
    /// Dieses stellt sicher das wir für jeden Druckertypen einen eigenen Handler haben
    /// und für jeden eine funktion für das Drucken bereitgestellt wird
    /// </summary>
    public interface IPrinterHandler
    {
        PrinterType Type { get; }

        void Print(string document);

    }
}
