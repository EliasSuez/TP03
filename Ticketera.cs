static class Ticketera
{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 0;

    static int DevolverUltimoID()
    {
        UltimoIDEntrada++;
        return UltimoIDEntrada;
    }

    public static int AgregarCliente(Cliente cliente)
    {
        int key = Ticketera.DevolverUltimoID();
        DicClientes.Add(key, cliente);
        return key;
    }

    public static Cliente BuscarCliente()
    {
        int IdABuscar;
        do{
        Console.WriteLine("Ingrese un ID para mostrar datos del cliente");
        IdABuscar = int.Parse(Console.ReadLine());
        }while(IdABuscar < 0);
        if(DicClientes.ContainsKey(IdABuscar))
        {

        }
        else 
        {
            Console.WriteLine("No se encontró un cliente con ese ID");
        }
        
    }

    public static int CambiarEntrada(int ID, int Tipo, int Cantidad)
    {

    }

    public static List<string> EstadisticasTicketera()
    {

    }
}