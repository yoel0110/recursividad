using System;
using System.Collections.Generic;
using System.Text;

namespace recursividad
{
 
    public class Asset_Management
    {
        public decimal ValorDeCompra { get; private set; }
        public decimal TasaDepreciacion { get; private set; }
        public decimal FactorRetencion { get; private set;}
        public int AñoDeVida { get;  private set; } = 0;
        public decimal ValorContable { get; set; }


        private Asset_Management(){}


        public decimal CalculodeDepreciacion(int t)
        {
            if (t == 0)
            {
                Console.WriteLine($"Año {t}: {ValorDeCompra:F2}");
                return ValorDeCompra;
            }
            ValorContable = CalculodeDepreciacion(t - 1) * FactorRetencion;
            Console.WriteLine($"Año {t}: {ValorContable:F2}");
            return ValorContable;
        }

        private void calcularFactorRentencion(decimal tasa)
        {
            this.FactorRetencion = 1 - (tasa / 100);
        }

        public static Asset_Management AssetManagementBuilder()
        {
            try
            {
                var asm = new Asset_Management();
                decimal input;
                Console.WriteLine("Inserte el valor de compra: ");
                decimal.TryParse(Console.ReadLine(), out input);
                asm.ValorDeCompra = input;
                Console.WriteLine("Inserte la tasa de depreciación anual: ");
                decimal.TryParse(Console.ReadLine(), out input);
                asm.TasaDepreciacion = input;
                asm.calcularFactorRentencion(asm.TasaDepreciacion);
                Console.WriteLine("Inserte los Años de vida útil transcurridos: ");
                decimal.TryParse(Console.ReadLine(), out input);
                asm.AñoDeVida = (int)input;
                return asm;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new();
            }
        }
    }
}
