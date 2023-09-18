using DelegationDesignPattern.Common;
using DelegationDesignPattern.Handlers;
using DelegationDesignPattern.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
        PrinterManger printerManager = new PrinterManger();

        printerManager.RegisterHandler(new InkjetPrinterHandler());
        printerManager.RegisterHandler(new LaserPrinterHandler());

        printerManager.Print("Document1.pdf", PrinterType.Inkjet);
        printerManager.Print("Document2.pdf", PrinterType.Laser);

        Console.WriteLine("Available printer types:");
        foreach (var type in printerManager.GetRegisteredPrinterTypes())
        {
            Console.WriteLine($" - {type}");
        }

        Console.ReadLine();
    }
}