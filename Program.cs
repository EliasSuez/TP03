using System.Collections;

int dni = 0, tipoEntrada = 0, cantidad = 0;
string apellido = "", nombre = "";
double fechaInscripcion = 0; 

ValidarDatos(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);

Cliente cliente1 = new Cliente(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);

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

static void ValidarDatos(int dni,int tipoEntrada,int cantidad, string apellido,string nombre, double fechaInscripcion)
{
do{
dni = IngresarNumero("Ingrese el DNI");
}while(dni < 0);
do{
tipoEntrada = IngresarNumero("Ingrese el tipo de entrada, 1, 2, 3 o 4");
}while(tipoEntrada < 0 || tipoEntrada > 4);
do
{
cantidad = IngresarNumero("Ingrese la cantidad de entradas");
}while(cantidad < 0);
do
{
apellido = IngresarTexto("Ingrese el apellido");
}while(apellido != " ");
do
{
nombre = IngresarTexto("Ingrese el nombre");
}while(apellido != " ");
do
{
fechaInscripcion = IngresarNumeroD("Ingrese la cantidad de entradas");
}while(cantidad < 0);
}