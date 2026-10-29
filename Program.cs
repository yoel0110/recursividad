 

namespace recursividad;

public class Program
{
    public static void Main(string[] args)
    {
        //Asset_Management asset = Asset_Management.AssetManagementBuilder();
        //asset.CalculodeDepreciacion(asset.AñoDeVida);

        CompoundInterest ci = CompoundInterest.CompoundInterestBuilder();
        ci.CalcularIversion();
    }
}