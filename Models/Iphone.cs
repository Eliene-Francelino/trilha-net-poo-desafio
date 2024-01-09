using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone, chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Implementação do construtor, se necessário
        }

        // Sobrescreve o método abstrato InstalarAplicativo da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no iPhone.");
        }
    }
}