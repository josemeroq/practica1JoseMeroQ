using System;
using System.Collections.Generic;
using System.Text;

namespace practica1JoseMeroQ
{
    public class PreOrden : OrdenBase
    {
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del predio total de un pedido anticipado");
            return productos.Sum(x => x.Precio) * 0.9;
        }
    }
}