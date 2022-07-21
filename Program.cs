using System;

namespace practica1JoseMeroQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularOrden = new OrdenRegular();
            Console.WriteLine(regularOrden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var preorden = new PreOrden();
            Console.WriteLine(preorden.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var ordenPremium = new OrdenPremium(preorden);
            Console.WriteLine(ordenPremium.CalcularTotalPrecioOrden());
            Console.WriteLine();
        }
    }
}
