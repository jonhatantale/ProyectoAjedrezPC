class Tablero
{
    public Pieza[,] matriz = new Pieza[8, 8];

    public void Inicializar()
    {
        // piezas para ejemplo del tablero 
        matriz[0, 0] = new Pieza("Torre", 1);
        matriz[0, 1] = new Pieza("Soldado", 1);
        matriz[7, 7] = new Pieza("Torre", 2);
        matriz[7, 6] = new Pieza("Soldado", 2);
    }

    public void Mostrar()
    {
        Console.WriteLine("\nTABLERO:");

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matriz[i, j] == null)
                {
                    Console.Write("[   ] ");
                }
                else
                {
                    string letra = matriz[i, j].Tipo;
                    int jugador = matriz[i, j].Jugador;
                    Console.Write($"[{letra}{jugador}] ");
                }
            }
            Console.WriteLine();
        }
    }
}