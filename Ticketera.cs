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

    public static Cliente BuscarCliente(int IdABuscar)
    {
        Cliente clienteBuscado;
        if(DicClientes.ContainsKey(IdABuscar))
        {
            clienteBuscado = DicClientes[IdABuscar];
        }
        else 
        {
            clienteBuscado = null;
        }
        return clienteBuscado;
    }

    public static int CambiarEntrada(int ID, int Tipo, int Cantidad)
    {

    }

    public static List<string> EstadisticasTicketera()
    {

    }
}