using System;
using System.Collections.Generic;

namespace Mercado._02_Modulo_Productos
{
    class ServiocioProductos
    {
        // 2) Módulo de Productos: 
        // Crear producto: Nombre, precio, cantidad, código(este código no se puede repetir).
        //	Buscar producto(se busca por el código).
        //	Modificar producto(se busca por el código y luego se edita).
        //	Eliminar producto(se busca por el código y luego se elimina).

        private readonly List<Productos> CrearProductos = new();
        private readonly List<Factura> CrearFacturas = new();
        // 1 ================ Registrar los productos ======================== //
        public void RegistrarProductos(Productos Productos)
        {
            Console.WriteLine("\n¿ Ingresa el codigo del Producto ?");
            Productos.Codigo = int.Parse(Console.ReadLine());

            if (CrearProductos.Exists(element => element.Codigo == Productos.Codigo)) Console.WriteLine(" El Producto Esta Regitrado");
            else
            {
                Console.WriteLine("\n¿ Ingresa el Nombre del producto ?");
                Productos.Nombre = Console.ReadLine();

                Console.WriteLine("\n¿ Ingresa el precio del producto ?");
                Productos.Precio = double.Parse(Console.ReadLine());

                Console.WriteLine("\n¿ Ingresa la cantidad del producto");
                Productos.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("\nProducto Guardado Exitosamente ");
                CrearProductos.Add(Productos);
            }


        }






        // 2 ================ Buscar Productos ======================== //
        public void BuscarProductos(Productos Productos)
        {
            Console.WriteLine("\n          ==================== Buscar Productos ====================\n");

            Console.WriteLine("Ingrese el Producto a buscar");
            Productos.Codigo = int.Parse(Console.ReadLine());

            Productos Buscar = CrearProductos.Find(x => x.Codigo == Convert.ToInt32(Productos.Codigo));

            if (Buscar != null)
            {
                Console.WriteLine("\n¿ Codigo del producto ? ");
                Console.WriteLine(Productos.Codigo = Buscar.Codigo);
                Console.WriteLine("\nNombre del Producto");
                Console.WriteLine(Productos.Nombre = Buscar.Nombre);
                Console.WriteLine("\nPrecio del Producto");
                Console.WriteLine(Productos.Precio = Buscar.Precio);
                Console.WriteLine("\nCantidad del Producto");
                Console.WriteLine(Productos.Cantidad = Buscar.Cantidad);


                while (true)
                {
                    string menu;
                    Console.WriteLine("Deseas Buscar otro Producto  --SI-- o --NO--");
                    menu = Console.ReadLine();
                    if (Productos.Codigo != 0)
                    {
                        if (menu == "SI" || menu == "si") BuscarProductos(Productos);
                        else if (menu == "No" || menu == "no") break;
                        else break;
                    }

                }
            }
            else Console.WriteLine("Condigo del producto no existe");

        }






        // 3 ================ Eliminar Productos ======================== //
        public void EliminarProductos(Productos Productos)
        {
            MostrarProductos();
            Console.WriteLine("Ingrese el Codigo del producto a eliminar");
            Productos.Codigo = int.Parse(Console.ReadLine());
            CrearProductos.RemoveAll(x => x.Codigo == Convert.ToInt32(Productos.Codigo));
            Console.WriteLine("\n          ==================== Producto Eliminado ====================\n Productos restantes");
            MostrarProductos();

            while (true)
            {
                string menu;
                Console.WriteLine("Deseas elimiar otro Producto  --SI-- o --NO--");
                menu = Console.ReadLine();
                if (Productos.Codigo != 0)
                {
                    if (menu == "SI" || menu == "si") EliminarProductos(Productos);
                    else if (menu == "No" || menu == "no") break;
                    else break;
                }
                else Console.WriteLine("Ya no se puede eliminar");
            }
        }





        // 4 ================ Modificar Productos ======================== //
        public void ModificarProductos(Productos Productos)
        {
            Console.WriteLine("\n          ==================== Modificar Productos ====================");

            Console.WriteLine("Ingrese el Codigo a Modificar");
            Productos.Codigo = int.Parse(Console.ReadLine());

            Productos Modificar = CrearProductos.Find(x => x.Codigo == Convert.ToInt32(Productos.Codigo));

            if (Modificar != null)
            {
                sbyte opcion;
                Console.WriteLine("Que deseas Modificar ? 1) Codigo del Producto\n 2) Nombre del Producto\n 3) Precio del Producto\n 4) Cantidad del Producto");
                opcion = sbyte.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("\nIngrese el nuevo Codigo");
                    Modificar.Codigo = Productos.Codigo = int.Parse(Console.ReadLine());
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nIngrese el nuevo Nombre del producto");
                    Modificar.Nombre = Productos.Nombre = Console.ReadLine();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\n¿ Ingrese el nuevo Precio ?");
                    Modificar.Precio = Productos.Precio = double.Parse(Console.ReadLine());
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\n¿ Ingrese la nueva Cantidad ?");
                    Modificar.Cantidad = Productos.Cantidad = int.Parse(Console.ReadLine());
                }

            }
            while (true)
            {
                string menu;
                Console.WriteLine("Deseas Modificar otro Producto  --SI-- o --NO--");
                menu = Console.ReadLine();
                if (Productos.Codigo != 0)
                {
                    if (menu == "SI" || menu == "si") ModificarProductos(Productos);
                    else if (menu == "No" || menu == "no") break;
                    else break;
                }

            }
        }




        // 5 ================ Mostrar Productos ======================== //
        public void MostrarProductos()
        {
            Console.WriteLine("\n                   ==================== Productos ==================== \n");
            foreach (var Producto in CrearProductos)
            {
                Console.WriteLine("N° del Codigo: {0}      Nombre: {1}      Precio: $ {2} pesos       Cantidad: {3} Unidades", Producto.Codigo, Producto.Nombre, Producto.Precio, Producto.Cantidad);
            }
        }






        // 6 ================ Factura ======================== //
        public void Facturas(Productos Productos, Factura Factura)
        {
            Random r = new Random();
            int Cantidad;
            double Total;


            Factura.Facturas = r.Next(1000,9999);
            Console.WriteLine("\n               ======================== FACTURA {0} ========================", Factura.Facturas);
            MostrarProductos();
            Console.WriteLine("\nIngrese el Producto a pedir Con el codigo");
            Productos.Codigo = int.Parse(Console.ReadLine());
            Productos Buscar = CrearProductos.Find(x => x.Codigo == Convert.ToInt32(Productos.Codigo));

            if (Buscar != null)
            {
                Productos.Nombre = Buscar.Nombre;
                Productos.Precio = Buscar.Precio;
                Productos.Cantidad = Buscar.Cantidad;
                Console.WriteLine("Cantidad a pedir del Producto");
                Cantidad = int.Parse(Console.ReadLine());

                Total = Cantidad * Buscar.Precio;
                Buscar.Cantidad -= Cantidad;

                if (Cantidad > Buscar.Cantidad)
                {
                    Console.WriteLine("Producto insuficiente");
                    Facturas(Productos,Factura);
                }
                else
                {
                    Factura.Nombre = Buscar.Nombre;
                    Factura.Precio = Buscar.Precio;
                    Factura.Cantidad = Cantidad;
                    Factura.Total = Total;
                    CrearFacturas.Add(Factura);

                    Console.WriteLine("N° de Factura: {0}, Productos a comprar: {1}, Precio del Producto $ {2} pesos, Cantidad a comprar: {3} unidades, Total a pagar $ {4} pesos ", Factura.Facturas, Factura.Nombre, Factura.Precio, Factura.Cantidad, Factura.Total);


                }

            }
            else Console.WriteLine("El producto no esta registrado");
        }


        public void MostrarFactura()
        {
            Console.WriteLine("\n                   ==================== Facturas ==================== \n");
            foreach (var Factura in CrearFacturas)
            {
                Console.WriteLine("N° de Factura: {0}  Productos a comprar: {1}  Precio del Producto $ {2} pesos Cantidad a comprar: {3} unidades  Total a pagar $ {4} pesos \n", Factura.Facturas, Factura.Nombre, Factura.Precio, Factura.Cantidad, Factura.Total);

            }
        }




        // 7 ================ Buscar factura =================

        public void BuscarFactura(Factura Factura) 
        {
            Console.WriteLine("\n          ==================== Buscar Factura ====================\n");

            Console.WriteLine("Ingrese el prosucto a buscar");
            Factura.Facturas = int.Parse(Console.ReadLine());
            
            Factura  Buscar = CrearFacturas.Find(x => x.Facturas == Convert.ToInt32(Factura.Facturas));

            if (Buscar != null)
            {
                Factura.Facturas = Buscar.Facturas;
                Factura.Nombre = Buscar.Nombre;
                Factura.Precio = Buscar.Precio;
                Factura.Cantidad = Buscar.Cantidad;
                Factura.Total = Buscar.Total;

                Console.WriteLine("N° de Factura: {0}  Productos a comprar: {1}  Precio del Producto $ {2} pesos Cantidad a comprar: {3} unidades  Total a pagar $ {4} pesos", Buscar.Facturas, Buscar.Nombre, Buscar.Precio, Buscar.Cantidad, Buscar.Total);

                while (true)
                {
                    string menu;
                    Console.WriteLine("\nDeseas Buscar otro Producto  --SI-- o --NO--");
                    menu = Console.ReadLine();
                    if (Factura.Facturas != 0)
                    {
                        if (menu == "SI" || menu == "si") MostrarFactura();
                        else if (menu == "No" || menu == "no") break;
                        else break;
                    }

                }
            }
            else Console.WriteLine("Condigo de la factura no existe");
        }





        // 8 ================ 10 Productos ======================== //


        public void Listar(Productos Productos)
        {
            Productos producto1 = new()
            {
                Codigo = 1,
                Nombre = "Manzana",
                Precio = 1200,
                Cantidad = 600
            };

            Productos producto2 = new()
            {
                Codigo = 2,
                Nombre = "Pera   ",
                Precio = 1400,
                Cantidad = 500
            };

            Productos producto3 = new()
            {
                Codigo = 3,
                Nombre = "Mango  ",
                Precio = 1400,
                Cantidad = 500
            };

            Productos producto4 = new()
            {
                Codigo = 4,
                Nombre = "Banano ",
                Precio = 1000,
                Cantidad = 800
            };

            Productos producto5 = new()
            {
                Codigo = 5,
                Nombre = "Piña   ",
                Precio = 1500,
                Cantidad = 850
            };

            Productos producto6 = new()
            {
                Codigo = 6,
                Nombre = "Patilla",
                Precio = 2000,
                Cantidad = 900
            };

            Productos producto7 = new()
            {
                Codigo = 7,
                Nombre = "Coco   ",
                Precio = 3500,
                Cantidad = 400
            };

            Productos producto8 = new()
            {
                Codigo = 8,
                Nombre = "Naranja",
                Precio = 1200,
                Cantidad = 700
            };

            Productos producto9 = new()
            {
                Codigo = 9,
                Nombre = "Fresas ",
                Precio = 1000,
                Cantidad = 990
            };

            Productos producto10 = new()
            {
                Codigo = 10,
                Nombre = "Uvas   ",
                Precio = 1000,
                Cantidad = 850
            };

            Productos.Codigo = producto1.Codigo;
            if (CrearProductos.Exists(element => element.Codigo == Productos.Codigo)) Console.WriteLine("\n Los clientes y los Producto Estan Regitrado");
            else
            {
                Console.WriteLine("Clientes y Productos Agregados");
                CrearProductos.Add(producto1);
                CrearProductos.Add(producto2);
                CrearProductos.Add(producto3);
                CrearProductos.Add(producto4);
                CrearProductos.Add(producto5);
                CrearProductos.Add(producto6);
                CrearProductos.Add(producto7);
                CrearProductos.Add(producto8);
                CrearProductos.Add(producto9);
                CrearProductos.Add(producto10);
            }


        }
    }
}






