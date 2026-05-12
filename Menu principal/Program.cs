class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== JUEGO DE TABLERO =====");
            Console.WriteLine("1. Iniciar partida");
            Console.WriteLine("2. Ver reglas");
            Console.WriteLine("3. Ver puntaje más alto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IniciarJuego();
                    break;

                case 2:
                    Console.WriteLine("\nReglas básicas:");
                    Console.WriteLine("- Rey se mueve 1 casilla en cualquier dirección");
                    Console.WriteLine("- Torre se mueve en línea recta");
                    Console.WriteLine("- Soldado avanza una casilla y ataca en diagonal");
                    break;

                case 3:
                    Console.WriteLine("\nAún no hay puntajes registrados"); // aqui no tengo idea de como meter los puntajes 
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }

    static void IniciarJuego()
    {
        Console.Write("\nNombre del jugador 1: ");
        Jugador j1 = new Jugador(Console.ReadLine());

        Console.Write("Nombre del jugador 2: ");
        Jugador j2 = new Jugador(Console.ReadLine());

        Tablero tablero = new Tablero();
        tablero.Inicializar();

        int turno = 1;

        // Bucle del juego creo que va aqui o sea pra que haga los cambios de a quien le toca 

    }
}