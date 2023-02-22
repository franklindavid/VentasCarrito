using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    Idcarrito int primary key identity,
//Idcliente int references cliente(IdCliente),
//IdProducto int references producto(IdProducto),
//Cantidad int
    public class Carrito
    {
        public int Idcarrito { get; set; }
        public Cliente ocliente { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
