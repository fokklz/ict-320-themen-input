using DelegationDesignPattern.Common;
using DelegationDesignPattern.Handlers;
using DelegationDesignPattern.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
        PrinterManger printerManager = new PrinterManger();

        // Rehgistrieren der Druckerhandler
        printerManager.RegisterHandler(new InkjetPrinterHandler());
        printerManager.RegisterHandler(new LaserPrinterHandler());

        // Drucken von Dokumenten
        printerManager.Print("Dokument1.pdf", PrinterType.Inkjet);
        printerManager.Print("Dokument2.pdf", PrinterType.Laser);

        // Auflisten der verfügbaren Druckertypen
        Console.WriteLine("Verfügbare Druckertypen:");
        foreach (var type in printerManager.GetRegisteredPrinterTypes())
        {
            Console.WriteLine($" - {type}");
        }

        Console.ReadLine();
    }
}