
class Cliente
{
    public int DNI { get; private set; }
    public int TipoEntrada { get; set; }
    public int Cantidad { get; set; }
    public string Apellido { get; private set; }
    public string Nombre { get; private set; }
    public double FechaInscripcion { get; set; }
  
    public Cliente(int dni, int tipoEntrada, int cantidad, string apellido, string nombre, double fechaInscripcion)
    {
        DNI = dni;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscripcion = fechaInscripcion;
    }


    public static int Dinero(int TipoEntrada, int cantidad)
    {
        int[] precios = {45000, 60000, 30000, 100000}; 
        int dinerGastado = 0;
        for (int i = 1; i < 4; i++)
        {
            if(TipoEntrada == i)
            {
                dinerGastado = precios[i] * cantidad;
            }
        }
        return dinerGastado;
    }
}
