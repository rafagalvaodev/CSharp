using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TemperaturaCel, TemperaturaFah, TemperaturaKel;
            Console.WriteLine("\\\\\\\\Conversor de Temperatura////");
            Console.Write("Digite a temperatura em graus celsius: ");
            TemperaturaCel = double.Parse(Console.ReadLine());

            TemperaturaFah = (TemperaturaCel * 1.8) + 32;
            TemperaturaKel = TemperaturaCel + 273.15;

            Console.WriteLine("A temperatura de " + TemperaturaCel + "°C" + " em Fahrenheit é " + TemperaturaFah + "°F\n");
            Console.WriteLine("A temperatura de " + TemperaturaCel +"°C" +" em Fahrenheit é " + TemperaturaKel+ "°K");



            Console.ReadKey();




        }
    }
}
