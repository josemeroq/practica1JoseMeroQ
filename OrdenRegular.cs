using System;
using System.Collections.Generic;
using System.Text;

namespace practica1JoseMeroQ
{
    public class OrdenRegular : OrdenBase
    {
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del predio total de un pedido normal");
            return productos.Sum(x => x.Precio);

        }
    }
}
