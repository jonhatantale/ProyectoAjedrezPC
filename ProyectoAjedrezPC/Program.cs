namespace ProyectoAjedrezPC;

class Program
{
    // Credenciales definidas por el grupo
    const string USUARIO = "admin";
    const string CONTRASENA = "1234";

    static Puntaje record = new Puntaje();

    static void Main(string[] args)
    {
        Console.Title = "Juego de Estrategia en Tablero";

        // Login obligatorio antes de entrar al menú
        if (!Login())
        {
            Console.WriteLine("Demasiados intentos fallidos. Cerrando...");
            return;
        }

        // Login con contraseña oculta (asteriscos)
        static bool Login()
        {
            int intentos = 0;

            while (intentos < 3)
            {
                Console.Clear();
                Console.WriteLine("INICIO DE SESIÓN");
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contrasena = LeerContrasenaOculta();

                if (usuario == USUARIO && contrasena == CONTRASENA)
                {
                    Console.WriteLine("\n✓ Acceso concedido.");
                    Thread.Sleep(1000);
                    return true;
                }

                intentos++;
                Console.WriteLine($"\nCredenciales incorrectas. Intentos restantes: {3 - intentos}");
                Thread.Sleep(1500);
            }

            return false;
        }

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

