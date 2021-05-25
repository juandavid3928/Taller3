using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado._02_Modulo_Productos
{
    class Productos
    {
        // 2) Módulo de Productos: 
        // Crear producto: Nombre, precio, cantidad, código(este código no se puede repetir).
        //	Buscar producto(se busca por el código).
        //	Modificar producto(se busca por el código y luego se edita).
        //	Eliminar producto(se busca por el código y luego se elimina).


        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

    }
}
