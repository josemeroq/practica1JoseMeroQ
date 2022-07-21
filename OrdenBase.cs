using System;
using System.Collections.Generic;
using System.Text;

namespace practica1JoseMeroQ
{
    public abstract class OrdenBase
    {
        protected List<Product> productos = new List<Product>
    {
        new Product{Nombre = "Telefono",Precio = 300},
        new Product{Nombre = "Tablet",Precio = 800},
        new Product{Nombre = "PC Gamer",Precio = 1800}
    };
        public abstract double CalcularTotalPrecioOrden();
    }
}
