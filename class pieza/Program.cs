class Pieza
{
    public string Tipo; // Rey, Torre, Soldado o sea los que hay pues 
    public int Jugador; // aqui que jugador es el 1 o el 2

    public Pieza(string tipo, int jugador)
    {
        Tipo = tipo;
        Jugador = jugador;
    }
}