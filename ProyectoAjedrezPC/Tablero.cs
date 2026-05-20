using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
    internal class Tablero
    {
       
        private Pieza[,] matriz = new Pieza[8, 8];

       public void IniciarTablero(Jugador jugadorBlanco, Jugador jugadorNegro)
        {
            //Piezas BLANCAS (fila 7 y 6)
            matriz[7, 0] = new Torre("Blanco", 7, 0);
            matriz[7, 7] = new Torre("Blanco", 7, 7);
            matriz[7, 4] = new Rey("Blanco", 7, 4);
            matriz[6, 1] = new Soldado("Blanco", 6, 1);
            matriz[6, 2] = new Soldado("Blanco", 6, 2);
            matriz[6, 5] = new Soldado("Blanco", 6, 5);
            matriz[6, 6] = new Soldado("Blanco", 6, 6);

            //Piezas NEGRAS (fila 0 y 1)
            matriz[0, 0] = new Torre("Negro", 0, 0);
            matriz[0, 7] = new Torre("Negro", 0, 7);
            matriz[0, 4] = new Rey("Negro", 0, 4);
            matriz[1, 1] = new Soldado("Negro", 1, 1);
            matriz[1, 2] = new Soldado("Negro", 1, 2);
            matriz[1, 5] = new Soldado("Negro", 1, 5);
            matriz[1, 6] = new Soldado("Negro", 1, 6);
        }

        // Muestra el tablero en consola
        public void Mostrar()
        {
            Console.WriteLine("\n    A   B   C   D   E   F   G   H");
            Console.WriteLine("  +---+---+---+---+---+---+---+---+");

            for (int f = 0; f < 8; f++)
            {
                Console.Write($"{8 - f} |");
                for (int c = 0; c < 8; c++)
                {
                    if (matriz[f, c] == null)
                        Console.Write(" . |");
                    else
                        Console.Write($" {matriz[f, c].Simbolo} |");
                }
                Console.WriteLine($" {8 - f}");
                Console.WriteLine("  +---+---+---+---+---+---+---+---+");
            }
            Console.WriteLine("    A   B   C   D   E   F   G   H\n");
        }

        // Convierte coordenada tipo "B4" a fila y columna de la matriz
        public bool ParsearCasilla(string casilla, out int fila, out int columna)
        {
            fila = -1;
            columna = -1;

            if (casilla.Length != 2) return false;

            char letra = char.ToUpper(casilla[0]);
            char numero = casilla[1];

            if (letra < 'A' || letra > 'H') return false;
            if (numero < '1' || numero > '8') return false;

            columna = letra - 'A';
            fila = 8 - (numero - '0');
            return true;
        }

        // Intenta mover una pieza, retorna la pieza capturada (o null)
        public Pieza MoverPieza(int filaOrigen, int colOrigen, int filaDestino, int colDestino, string colorTurno)
        {
            Pieza pieza = matriz[filaOrigen, colOrigen];

            // Validaciones generales
            if (pieza == null) return null;
            if (pieza.Color != colorTurno) return null;

            Pieza destino = matriz[filaDestino, colDestino];

            // No puede caer en casilla propia
            if (destino != null && destino.Color == colorTurno) return null;

            // Valida movimiento según la pieza
            if (!pieza.MovimientoValido(filaDestino, colDestino, matriz)) return null;

            // Ejecutar el movimiento
            matriz[filaOrigen, colOrigen] = null;
            matriz[filaDestino, colDestino] = pieza;
            pieza.Fila = filaDestino;
            pieza.Columna = colDestino;

            return destino; // retorna la pieza capturada (null si no hubo captura)
        }

        // Verifica si el rey de un color sigue en el tablero
        public bool ReyVivo(string color)
        {
            for (int f = 0; f < 8; f++)
                for (int c = 0; c < 8; c++)
                    if (matriz[f, c] is Rey && matriz[f, c].Color == color)
                        return true;
            return false;
        }

        // Verifica si un jugador tiene piezas
        public bool TienePiezas(string color)
        {
            for (int f = 0; f < 8; f++)
                for (int c = 0; c < 8; c++)
                    if (matriz[f, c] != null && matriz[f, c].Color == color)
                        return true;
            return false;
        }

        // Acceso directo a la matriz (para validaciones externas)
        public Pieza ObtenerPieza(int fila, int columna)
        {
            return matriz[fila, columna];
        }

    }
}
