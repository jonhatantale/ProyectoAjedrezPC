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

    // Lee la contraseña mostrando asteriscos
    static string LeerContrasenaOculta()
    {
        string contrasena = "";
        ConsoleKeyInfo tecla;

        do
        {
            tecla = Console.ReadKey(true);

            if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
            {
                contrasena += tecla.KeyChar;
                Console.Write("*");
            }
            else if (tecla.Key == ConsoleKey.Backspace && contrasena.Length > 0)
            {
                contrasena = contrasena.Substring(0, contrasena.Length - 1);
                Console.Write("\b \b");
            }

        } while (tecla.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return contrasena;
    }

    //Lógica del juego

    static void MostrarReglas()
    {
        Console.Clear();
        Console.WriteLine("REGLAS DEL JUEGO\n");
        Console.WriteLine("• REY (R/r): Se mueve 1 casilla en cualquier dirección.");
        Console.WriteLine("• TORRE (T/t): Se mueve en línea recta. No puede saltar piezas.");
        Console.WriteLine("• SOLDADO (S/s): Avanza 1 casilla. Ataca en diagonal. No retrocede.\n");
        Console.WriteLine("• Mayúsculas = Blancas | Minúsculas = Negras");
        Console.WriteLine("• Si capturas el Rey rival o eliminas todas sus piezas, ganas.\n");
        Console.WriteLine("Puntaje:");
        Console.WriteLine("  Soldado o Torre capturada → 10 puntos");
        Console.WriteLine("  Rey capturado → 60 puntos\n");
        Console.WriteLine("Presiona Enter para volver...");
        Console.ReadLine();
    }

}

