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