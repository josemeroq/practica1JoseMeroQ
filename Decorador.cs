using System;
using System.Collections.Generic;
using System.Text;

namespace practica1JoseMeroQ
{
    public class Decorador : OrdenBase
    {
        protected OrdenBase orden;
        public Decorador(OrdenBase orden)
        {
            this.orden = orden;
        }

        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Calculo desde la clase decorador");
            return orden.CalcularTotalPrecioOrden();
        }
    }
}
