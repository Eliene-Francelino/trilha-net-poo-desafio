using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Testes com Nokia
            Console.WriteLine("Testes com Nokia:");
            Smartphone nokia = new Nokia("75315912", "Nokia XYZ", "IMEI123", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("NokiaApp1");

            Console.WriteLine();

            // Testes com iPhone
            Console.WriteLine("Testes com iPhone:");
            Smartphone iphone = new Iphone("95135732", "iPhone 15", "IMEI456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("iPhoneApp1");

            Console.ReadLine();
        }
    }
}