using System;
using System.Collections.Generic;
using System.Text;

namespace recursividad 
{
    public class CompoundInterest
    {
        public decimal CapitalInicial { get; private set; }
        public decimal TasaDeInteres { get; private set; }
        public decimal InteresExpresado => TasaDeInteres / 100;
        public int AñosDeInversion { get; set; }


        public void CalcularIversion()
        {
            CalcularInversion(AñosDeInversion); //Recursion Indirecta
        }

        public decimal CalcularInversion(int n)
        {
            if(n == 0)
            {
                Console.WriteLine($"Año {n}: {CapitalInicial:F2}");
                return CapitalInicial;
            }
            var capitalAcomulado = CalcularInversion(n - 1) * (InteresExpresado + 1);
            Console.WriteLine($"Año {n}: {capitalAcomulado:F2}");
            return capitalAcomulado;
        }

        private CompoundInterest() { }

        public static CompoundInterest CompoundInterestBuilder()
        {
            var ci = new CompoundInterest();
            decimal input;
            Console.WriteLine("Inserte el capital inicial: ");
            decimal.TryParse(Console.ReadLine(), out input);
            ci.CapitalInicial = input;
            Console.WriteLine("Inserte la tasa de interes: ");
            decimal.TryParse(Console.ReadLine(), out input);
            ci.TasaDeInteres = input;
            Console.WriteLine("Inserte el tiempo de inversion: ");
            decimal.TryParse(Console.ReadLine(), out input);
            ci.AñosDeInversion = (int)input;
            return ci;
        }


    }
}
