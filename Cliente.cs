
class Cliente
{
    public int DNI { get; private set; }
    public int TipoEntrada { get; set; }
    public int Cantidad { get; set; }
    public string Apellido { get; private set; }
    public string Nombre { get; private set; }
    public DateTime FechaInscripcion { get; set; }
  
    public Cliente(int dni, int tipoEntrada, int cantidad, string apellido, string nombre, DateTime fechaInscripcion)
    {
        DNI = dni;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscripcion = fechaInscripcion;
    }

    public override string ToString()
    {
        return "DNI: " + DNI + ", Tipo de entrada: " + TipoEntrada + ", Cantidad: " + Cantidad + ", Nombre: " + Nombre + ", Apellido: " + Apellido + "Fecha de Inscripcion: " + FechaInscripcion;
    }
}
