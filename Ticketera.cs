static class Ticketera{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 0;

    static int DevolverUltimoID(){
        int numero;
        Random random = new Random();

        numero = random.Next(0000, 9999);

        return numero;
    }

    public static int AgregarCliente(Cliente cliente){
        int key = Ticketera.DevolverUltimoID();
        do{
        if(DicClientes.ContainsKey())
        {
            key = Ticketera.DevolverUltimoID();
        }
        while(!DicClientes.ContainsKey(GenericUriParserOptions));
            
        DicClientes.Add(key, cliente);
        return key;
    }

    public static Cliente BuscarCliente(int ID){

    }

    public static int CambiarEntrada(int ID, int Tipo, int Cantidad){

    }

    public static List<string> EstadisticasTicketera(){

    }
}
}