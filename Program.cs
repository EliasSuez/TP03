using System.Collections;
using System.Collections.Generic;

int dni = 0, tipoEntrada = 0, cantidad = 0, cantClientes = 0, opcion;
string apellido = "", nombre = "", ingreso;
double fechaInscripcion = 0;
List<int> DineroRecaudado = new List<int>();

Menu();
Console.WriteLine("Ingrese que opcion del menu quiere");
opcion = int.Parse(Console.ReadLine());
switch(opcion)
{
    case 1:
    
    break;
}


do{
ValidarDatos(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);
Cliente cliente = new Cliente(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);
cantClientes++;
DineroRecaudado.Add(Dinero(tipoEntrada, cantidad));
Console.WriteLine("Quiere continuar ingresando, SI o NO");
ingreso = Console.ReadLine().ToUpper();
}while(ingreso == "NO");




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
static double IngresarNumeroD(string mensaje)
{
    double ingreso;
    Console.WriteLine(mensaje);
    ingreso = int.Parse(Console.ReadLine());
    return ingreso;
}

static void ValidarDatos(int dni, int tipoEntrada, int cantidad, string apellido, string nombre, double fechaInscripcion)
{
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
    } while (apellido != " ");
    do
    {
        nombre = IngresarTexto("Ingrese el nombre");
    } while (apellido != " ");
    do
    {
        fechaInscripcion = IngresarNumeroD("Ingrese la cantidad de entradas");
    } while (cantidad < 0);
}
static void Menu()
{
Console.WriteLine("Nueva Inscripción");
Console.WriteLine("Obtener Estadísticas del Evento");
Console.WriteLine("Buscar Cliente");
Console.WriteLine("Cambiar entrada de un Cliente");
Console.WriteLine("Salir");
Console.WriteLine();
}