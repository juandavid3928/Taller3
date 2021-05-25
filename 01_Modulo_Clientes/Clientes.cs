namespace Mercado._01_Modulo_Clientes
{
    class Clientes
    {
        //1) Módulo de Clientes: 
        //	Crear cliente(no se pueden repetir, validar el documento): Nombre, dirección, teléfono, cédula.
        //	Buscar cliente(se busca con el numero de la cédula).
        //	Modificar cliente(se busca con el numero de la cédula y luego se edita).
        //	Eliminar cliente(se busca con el numero de la cédula y luego se elimina).

        
        public int Documento { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public double Numero { get; set; }

    }
}
