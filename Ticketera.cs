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

    public static bool CambiarEntrada(int ID, int Tipo, int CantidadEntradas)
    {
        DicClientes[ID].TipoEntrada = Tipo;
        DicClientes[ID].Cantidad = CantidadEntradas;
        DicClientes[ID].FechaInscripcion = DateTime.Now;
        return true; 
    }

    public static List<string> EstadisticasTicketera()
    {
        List<string> estadisticas = new List<string>();
        int[] precios = { 45000, 60000, 30000, 100000 };
        int totalClientes = DicClientes.Count;
        estadisticas.Add("Total de clientes inscritos: " + totalClientes);

        int[] cantTipoEntrada = new int[4];
        int[] recaudacionPorTipo = new int[4];
        IncioArray(cantTipoEntrada);
        foreach (Cliente cliente in DicClientes.Values)
        {
            cantTipoEntrada[cliente.TipoEntrada - 1] += cliente.Cantidad;
            recaudacionPorTipo[cliente.TipoEntrada - 1] += cliente.Cantidad * precios[cliente.TipoEntrada-1];
        }
        for (int i = 0; i < cantTipoEntrada.Length; i++)
        {
            estadisticas.Add("Cantidad de entradas vendidas para el tipo " + (i + 1) + ": " + cantTipoEntrada[i]);
            estadisticas.Add("Recaudación para el tipo de entrada " + (i + 1) + ": $" + recaudacionPorTipo[i]);
        }
        int recaudacionTotal = 0;
        foreach (Cliente cliente in DicClientes.Values)
        {
            recaudacionTotal += cliente.Cantidad * cliente.TipoEntrada;
        }
        estadisticas.Add("Recaudación total: " + recaudacionTotal);

        for (int i = 0; i < cantTipoEntrada.Length; i++)
        {
            double porcentaje = (double)cantTipoEntrada[i] / recaudacionTotal * 100;
            estadisticas.Add("Porcentaje de entradas vendidas para el tipo " + (i + 1) + ": " + porcentaje + "%");
        }

        return estadisticas;
    }
    static void IncioArray(int[] cantTipoEntrada)
{
    for (int i = 0; i < cantTipoEntrada.Length; i++)
    {
        cantTipoEntrada[i] = 0;
    }
}
}