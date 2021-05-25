using Mercado._01_Modulo_Clientes;
using Mercado._02_Modulo_Productos;
using System;

namespace Iniciar
{
    public class Inicio
    {
        static void Main(string[] args)
        {

            var Datos = new ServicioClientes();
            var Producto = new ServiocioProductos();
            sbyte select;
            int menu;
            string Titulo = "Mercado La 1", Titulo1 = "1 Menu Clientes", Titulo2 = "2 Menu Productos", Titulo3 = "3 Menu Ventas", Titulo4 = "4 Menu  Reportes";

            while (true)
            {
                try
                {
                    Console.WriteLine(
                       "\n  ==================== {0} ==================== \n" +
                       "     {1}        " + "       {2}\n " +
                       "  1) Registrar  Cliente      " + "    6) Registar  Producto\n " +
                       "  2) Buscar     Cliente      " + "    7) Buscar    Producto\n " +
                       "  3) Eliminar   Cliente      " + "    8) Eliminar  Producto\n " +
                       "  4) Modificar  Cliente      " + "    9) Modificar Producto\n " +
                       "  5) Mostrar    Clientes     " + "   10) Mostrar   Productos\n\n\n" +

                       "     {3}           " + "      {4} \n" +
                       "  11) Ventas                 " + "   14) Listar Clientes\n" +
                       "  12) Buscar Facturas        " + "   15) Listar Productos\n" +
                       "  13) Mostrar Facturas       " + "   16) Listar Facturas\n" +
                       "                             " + "   17) Listar Todo\n\n " +
                       "                  18) Configuracion" + "\n\nIngresa una Opcion", Titulo, Titulo1, Titulo2, Titulo3, Titulo4);
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    var Clientes = new Clientes();
                    var Productos = new Productos();
                    var Factura = new Factura();
                    switch (menu)
                    {
                        case 1:

                            Datos.RegistrarClientes(Clientes);
                            break;
                        case 2:
                            Datos.BuscarClientes(Clientes);
                            break;

                        case 3:
                            Datos.EliminarClientes(Clientes);
                            break;

                        case 4:
                            Datos.ModificarClientes(Clientes);
                            break;
                        case 5:
                            Datos.MostrarClientes();
                            break;
                        case 6:
                            Producto.RegistrarProductos(Productos);
                            break;
                        case 7:
                            Producto.BuscarProductos(Productos);
                            break;
                        case 8:
                            Producto.EliminarProductos(Productos);
                            break;
                        case 9:
                            Producto.ModificarProductos(Productos);
                            break;
                        case 10:
                            Producto.MostrarProductos();
                            break;
                        case 11:
                            Datos.MostrarClientes();
                            Console.WriteLine("\nIngrese el documento del Cliente ?");
                            Clientes.Documento = int.Parse(Console.ReadLine());

                            if (Clientes.Documento.Equals(Clientes.Documento))
                            {
                                Datos.Venta(Clientes);
                                Producto.Facturas(Productos,Factura);
                            }
                            else Console.WriteLine("valio");
                            break;
                        case 12:
                            Producto.BuscarFactura(Factura);
                            break;
                        case 13:
                            Producto.MostrarFactura();
                            break;
                        case 14:
                            Datos.MostrarClientes();
                            break;
                        case 15:
                            Producto.MostrarProductos();
                            break;
                        case 16:
                            Producto.MostrarFactura();
                            break;
                        case 17:
                            Datos.MostrarClientes();
                            Producto.MostrarProductos();
                            Producto.MostrarFactura();
                            break;
                        case 18:
                            Console.WriteLine(" 1) Nombre del la empresa\n 2) Nombre del  Menu Cliente \n 3) Nombre del  Menu Prodcuto\n 4) Nombre del  Menu Ventas\n 5) Nombre del  Menu Reporte\n 6) Agregar 10 Clientes y Productos");
                            select = sbyte.Parse(Console.ReadLine());
                            if (select == 1)
                            {
                                Console.WriteLine("Nombre de la empresa");
                                Titulo = Console.ReadLine();
                            }
                            else if (select == 2)
                            {
                                Console.WriteLine("Nombre del  Menu Cliente");
                                Titulo1 = Console.ReadLine();
                            }
                            else if (select == 3)
                            {
                                Console.WriteLine("Nombre del  Menu Prodcuto");
                                Titulo2 = Console.ReadLine();
                            }
                            else if (select == 4)
                            {
                                Console.WriteLine("Nombre del  Menu Ventas");
                                Titulo3 = Console.ReadLine();
                            }
                            else if (select == 5)
                            {
                                Console.WriteLine("Nombre del  Menu Reporte");
                                Titulo4 = Console.ReadLine();
                            }
                            else if (select == 6)
                            {
                                Datos.Listar(Clientes);
                                Producto.Listar(Productos);
                            }
                            break;
                        default:
                            Console.WriteLine("Ingrese una Opcion Correcta del 1 hasta 18");
                            break;
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Error.. por favor ingrese un Numero Correcto");
                }

                catch (System.OverflowException)
                { Console.WriteLine("Error.. por favor ingrese un Numero mas pequeño"); }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

    }

}

