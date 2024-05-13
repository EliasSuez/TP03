using System.Collections;
using System.Collections.Generic;

int cantClientes = 0, opcion, nuevaEntrada, cantEntradas;
string ingreso;
Dictionary<Cliente, int> DIClientes = new Dictionary<Cliente, int>();
Cliente cliente, clienteEncontrado;

do{
Menu();
Console.WriteLine("Ingrese que opcion del menu quiere");
opcion = int.Parse(Console.ReadLine());
}while(opcion < 1 || opcion > 5);
do
{
    Console.Clear();
    switch (opcion)
    {
        case 1:
            do
            {
                cliente = ObtenerCliente();
                cantClientes++;
                DIClientes.Add(cliente, Dinero(cliente.TipoEntrada, cliente.Cantidad));
                do
                {
                    Console.WriteLine("¿Quiere continuar ingresando? Ingrese SI o NO");
                    ingreso = Console.ReadLine().ToUpper();
                } while (ingreso != "SI" && ingreso != "NO");
            } while (ingreso != "NO");
            break;

        case 2:
            List<string> estadisticas = Ticketera.EstadisticasTicketera();
            foreach (string estadistica in estadisticas)
            {
                Console.WriteLine(estadistica);
            }

            break;

        case 3:
            int IdABuscar;
            do
            {
                Console.WriteLine("Ingrese un ID para mostrar datos del cliente");
                IdABuscar = int.Parse(Console.ReadLine());
            } while (IdABuscar < 0);
            cliente = Ticketera.BuscarCliente(IdABuscar);

            if (cliente == null)
            {
                Console.WriteLine("No se encontro un cliente con ese ID");
            }
            else
            {
                cliente.ToString();
            }
            break;

        case 4:
            do
            {
                do
                {
                    IdABuscar = IngresarNumero("Ingrese el ID a buscar");

                } while (IdABuscar < 0);
                do
                {
                    nuevaEntrada = IngresarNumero("Ingrese porque tipo de entrada la quiere cambiar, tiene que superar el costo de la anterior entrada");
                } while (nuevaEntrada < 1 || nuevaEntrada > 4);
                do
                {
                    cantEntradas = IngresarNumero("Ingrese la cantidad de entradas que quiere ahora");
                } while (cantEntradas < 0);
                clienteEncontrado = Ticketera.BuscarCliente(IdABuscar);
                if (clienteEncontrado == null)
                {
                    Console.WriteLine("No existe un cliente con ese ID");
                    clienteEncontrado.Cantidad = 0;
                }
            } while (clienteEncontrado.Cantidad * clienteEncontrado.TipoEntrada > cantEntradas * nuevaEntrada);

            bool cambio = Ticketera.CambiarEntrada(IdABuscar, nuevaEntrada, cantEntradas);
            int nuevMonto = Dinero(nuevaEntrada, cantEntradas);
            DIClientes[clienteEncontrado] = nuevMonto;
            if (cambio)
                Console.WriteLine("Se pudo hacer el cambio");
            else
                Console.WriteLine("No se pudo hacer el cambio");

            break;
    }
} while (opcion != 5);


static int Dinero(int tipoEntrada, int cantidad)
{
    int[] precios = { 45000, 60000, 30000, 100000 };
    int dinerGastado = 0;
    for (int i = 1; i < 4; i++)
    {
        if (tipoEntrada == i)
        {
            dinerGastado = precios[i] * cantidad;
        }
    }

    return dinerGastado;
}
static string IngresarTexto(string mensaje)
{
    string ingreso;
    Console.WriteLine(mensaje);
    ingreso = Console.ReadLine();

    return ingreso;
}
static int IngresarNumero(string mensaje)
{
    int ingreso;
    Console.WriteLine(mensaje);
    ingreso = int.Parse(Console.ReadLine());
    return ingreso;
}
static Cliente ObtenerCliente()
{
    DateTime fechaInscripcion;
    string apellido, nombre;
    int dni, tipoEntrada, cantidad;


    do
    {
        dni = IngresarNumero("Ingrese el DNI");
    } while (dni < 0);
    do
    {
        tipoEntrada = IngresarNumero("Ingrese el tipo de entrada, 1, 2, 3 o 4");
    } while (tipoEntrada < 0 || tipoEntrada > 4);
    do
    {
        cantidad = IngresarNumero("Ingrese la cantidad de entradas");
    } while (cantidad < 0);
    do
    {
        apellido = IngresarTexto("Ingrese el apellido");
    } while (apellido == "");
    do
    {
        nombre = IngresarTexto("Ingrese el nombre");
    } while (nombre == "");
    do
    {
        Console.WriteLine("Ingrese la fecha");
        fechaInscripcion = DateTime.Parse(Console.ReadLine());
    } while (fechaInscripcion < DateTime.Now);
    Cliente cliente = new Cliente(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);

    return cliente;
}
static void Menu()
{
    Console.WriteLine("i. Nueva Inscripción");
    Console.WriteLine("ii. Obtener Estadísticas del Evento");
    Console.WriteLine("iii. Buscar Cliente");
    Console.WriteLine("iv. Cambiar entrada de un Cliente");
    Console.WriteLine("v. Salir");
    Console.WriteLine();
}

