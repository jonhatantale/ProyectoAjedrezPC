namespace ProyectoAjedrezPC;

class Program
{
    // Credenciales definidas por el grupo
    const string USUARIO = "admin";
    const string CONTRASENA = "1234";

    static Puntaje record = new Puntaje();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("JUEGO DE TABLERO");
            Console.WriteLine("1. Iniciar juego");
            Console.WriteLine("2. Ver reglas del juego");
            Console.WriteLine("3. Ver puntaje más alto");
            Console.WriteLine("4. Salir");
            Console.Write("\nElige una opción: ");

            string entrada = Console.ReadLine();
            opcion = int.TryParse(entrada, out int op) ? op : 0;

            switch (opcion)
            {
                case 1:
                    IniciarPartida();
                    break;
                case 2:
                    MostrarReglas();
                    break;
                case 3:
                    Console.Clear();
                    record.MostrarRecord();
                    Console.WriteLine("\nPresiona Enter para volver...");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    break;
            }
        } while (opcion != 4);

    }
}

