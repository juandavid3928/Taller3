using System;
using System.Collections.Generic;
using Mercado._02_Modulo_Productos;


namespace Mercado._01_Modulo_Clientes
{
    class ServicioClientes
    {
        //1) Módulo de Clientes: 
        //	Crear cliente(no se pueden repetir, validar el documento): Nombre, dirección, teléfono, cédula.
        //	Buscar cliente(se busca con el numero de la cédula).
        //	Modificar cliente(se busca con el numero de la cédula y luego se edita).

        private readonly List<Clientes> CrearClientes = new();


        // 1 ================ Registrar clientes ======================== //
        public void RegistrarClientes(Clientes Clientes)
        {
            Console.WriteLine("\n¿ Ingresa tu Documento ?");
            Clientes.Documento = int.Parse(Console.ReadLine());

            if (CrearClientes.Exists(element => element.Documento == Clientes.Documento)) Console.WriteLine(" El Cliente Esta Regitrado");

            else
            {
                Console.WriteLine("\n¿ Ingresa tu Nombre ?");
                Clientes.Nombre = Console.ReadLine();

                Console.WriteLine("\n¿ Ingresa tu Numero telefonico ?");
                Clientes.Numero = double.Parse(Console.ReadLine());

                Console.WriteLine("\n¿ Ingresa tu Direccion?\n");
                Clientes.Direccion = Console.ReadLine();

                Console.WriteLine("\nCliente Guardado Exitosamente ");
                CrearClientes.Add(Clientes);
            }

        }



        // 2 ================ Buscar clientes ======================== //
        public void BuscarClientes(Clientes Clientes)
        {
            Console.WriteLine("\n          ==================== Buscar Clientes ====================\n");

            Console.WriteLine("Ingrese el Documento a buscar");
            Clientes.Documento = int.Parse(Console.ReadLine());

            Clientes Buscar = CrearClientes.Find(x => x.Documento == Convert.ToInt32(Clientes.Documento));

            if (Buscar != null)
            {
                Console.WriteLine("\nDocumento del Cliente");
                Console.WriteLine(Clientes.Documento = Buscar.Documento);
                Console.WriteLine("\nNombre del Cliente");
                Console.WriteLine(Clientes.Nombre = Buscar.Nombre);
                Console.WriteLine("\nTelefono del Cliente");
                Console.WriteLine(Clientes.Numero = Buscar.Numero);
                Console.WriteLine("\nDireccion del Cliente");
                Console.WriteLine(Clientes.Direccion = Buscar.Direccion);
            }
            else Console.WriteLine("El cliente no existe");

            while (true)
            {
                string menu;
                Console.WriteLine("Deseas Buscar otro cliente  --SI-- o --NO--");
                menu = Console.ReadLine();
                if (Clientes.Documento != 0)
                {
                    if (menu == "SI" || menu == "si") BuscarClientes(Clientes);
                    else if (menu == "No" || menu == "no") break;
                    else break;
                }
            }
        }


        // 3 ================ Eliminar clientes ======================== //
        public void EliminarClientes(Clientes Clientes)
        {
            Console.WriteLine("Ingrese el Documento a eliminar");
            Clientes.Documento = int.Parse(Console.ReadLine());
            CrearClientes.RemoveAll(x => x.Documento == Convert.ToInt32(Clientes.Documento));
            Console.WriteLine(
                "\n          ==================== Cliente Eliminado ====================\n Clientes restantes");
            MostrarClientes();

            while (true)
            {
                string menu;
                Console.WriteLine("Deseas elimiar otro cliente  --SI-- o --NO--");
                menu = Console.ReadLine();
                if (Clientes.Documento != 0)
                {
                    if (menu == "SI" || menu == "si") EliminarClientes(Clientes);
                    else if (menu == "No" || menu == "no") break;
                    else break;
                }
                else Console.WriteLine("Ya no se puede eliminar");
            }
        }


        // 4 ================ Modificar clientes ======================== //
        public void ModificarClientes(Clientes Clientes)
        {
            Console.WriteLine("\n          ==================== Modificar Clientes ====================");

            Console.WriteLine("Ingrese el Documento a Modificar");
            Clientes.Documento = int.Parse(Console.ReadLine());

            Clientes Modificar = CrearClientes.Find(x => x.Documento == Convert.ToInt32(Clientes.Documento));

            if (Modificar != null)

            {
                sbyte opcion;
                Console.WriteLine("Que deseas Modificar ? 1) Documento\n 2) Nombre\n 3) Telefono\n 4) Direccion");
                opcion = sbyte.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("\nIngrese el nuevo Documento");
                    Modificar.Documento = Clientes.Documento = int.Parse(Console.ReadLine());
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nIngrese el nuevo Nombre");
                    Modificar.Nombre = Clientes.Nombre = Console.ReadLine();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\nIngrese el nuevo Telefono");
                    Modificar.Numero = Clientes.Numero = double.Parse(Console.ReadLine());
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nIngrese la nueva Direccion");
                    Modificar.Direccion = Clientes.Direccion = Console.ReadLine();
                }

            }
            while (true)
            {
                string menu;
                Console.WriteLine("Deseas Modificar otro cliente  --SI-- o --NO--");
                menu = Console.ReadLine();
                if (Clientes.Documento != 0)
                {
                    if (menu == "SI" || menu == "si") ModificarClientes(Clientes);
                    else if (menu == "No" || menu == "no") break;
                    else break;
                }
                else Console.WriteLine("No hay Documento a modificar");
            }
        }


        // 5 ================ Mostrar clientes ======================== //
        public void MostrarClientes()
        {
            Console.WriteLine("\n                   ==================== Clientes ==================== \n");
            foreach (var Clientes in CrearClientes)
            {
                Console.WriteLine("N° Documento: {0}     Nombre: {1}      Telefono: {2}       Direccion: {3}",
                    Clientes.Documento, Clientes.Nombre, Clientes.Numero, Clientes.Direccion);
            }
        }



        // 6 ================ Cliente venta ======================== //
        public void Venta(Clientes Clientes)
        {
            DateTime fecha = DateTime.Now;

            Clientes Buscar = CrearClientes.Find(x => x.Documento == Convert.ToInt32(Clientes.Documento));

            if (Buscar != null)
            {
                Clientes.Documento = Buscar.Documento;
                Clientes.Nombre = Buscar.Nombre;

                Console.WriteLine("                     El Cliente Esta Regitrado \n\nInformacion del cliente con Numero de Documento: {0} y Nombre: {1} Fecha {2}", Clientes.Documento, Clientes.Nombre = Buscar.Nombre, fecha);
            }
            else
            {
                string opcion;
                Console.WriteLine("El Cliente no esta Registrado\n");

                Console.WriteLine(" Hacer otra Consulta--SI-- o --NO--");
                opcion = Console.ReadLine();
                if (opcion == "SI" || opcion == "si")
                {
                    Console.WriteLine("\nIngrese el documento del Cliente ?");
                    Clientes.Documento = int.Parse(Console.ReadLine());
                    if (Clientes.Documento.Equals(Clientes.Documento))
                    {
                        Venta(Clientes);
                    }
                    
                }
                else Console.WriteLine("Saliendo");
                Console.Clear();
            }

        }

    

        public void Listar(Clientes Clientes)
        {
            Clientes clientes1 = new()
            {
                Documento = 1007942287,
                Nombre = "Juan ",
                Numero = 3105444107,
                Direccion = "CR24 CLL 82"
            };

            Clientes clientes2 = new()
            {
                Documento = 1007942288,
                Nombre = "Keli ",
                Numero = 3116782345,
                Direccion = "CR34 CLL 82"
            };

            Clientes clientes3 = new()
            {
                Documento = 1007942289,
                Nombre = "Tomi ",
                Numero = 3145734876,
                Direccion = "CR54 CLL 02"
            };

            Clientes clientes4 = new()
            {
                Documento = 1007942210,
                Nombre = "Jose ",
                Numero = 3214986576,
                Direccion = "CR45 CLL 32"
            };

            Clientes clientes5 = new()
            {
                Documento = 1007942211,
                Nombre = "Kara ",
                Numero = 3134568765,
                Direccion = "CR23 CLL 43"
            };

            Clientes clientes6 = new()
            {
                Documento = 1007942212,
                Nombre = "Anni ",
                Numero = 3234834567,
                Direccion = "CR25 CLL 54"
            };

            Clientes clientes7 = new()
            {
                Documento = 1007942213,
                Nombre = "Anto ",
                Numero = 3123345654,
                Direccion = "CR56 CLL 34"
            };

            Clientes clientes8 = new()
            {
                Documento = 1007942214,
                Nombre = "David",
                Numero = 3134568765,
                Direccion = "CR21 CLL 45"
            };

            Clientes clientes9 = new()
            {
                Documento = 1007942215,
                Nombre = "Karen",
                Numero = 3165234768,
                Direccion = "CR87 CLL 34"
            };

            Clientes clientes10 = new()
            {
                Documento = 1007942216,
                Nombre = "Merli",
                Numero = 3134568765,
                Direccion = "CR87 CLL 12"
            };

            Clientes.Documento = clientes1.Documento;
            if (CrearClientes.Exists(element => element.Documento == Clientes.Documento)) Console.WriteLine();
            else
            {
                CrearClientes.Add(clientes1);
                CrearClientes.Add(clientes2);
                CrearClientes.Add(clientes3);
                CrearClientes.Add(clientes4);
                CrearClientes.Add(clientes5);
                CrearClientes.Add(clientes6);
                CrearClientes.Add(clientes7);
                CrearClientes.Add(clientes8);
                CrearClientes.Add(clientes9);
                CrearClientes.Add(clientes10);
            }


        }

    }
}