using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.models
{
    public class Iphome : Smartphone
    {
        public Iphome(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine("Abrindo a App Store");
            Console.WriteLine($"Buscando {aplicativo}");
            Console.WriteLine($"Instalando {aplicativo}");
        }

    }
}