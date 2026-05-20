using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
       class Torre : Pieza
        {
            public Torre(string color, int fila, int columna)
                : base(color, fila, columna, color == "Blanco" ? 'T' : 't') { }

            public override bool MovimientoValido(int filaDestino, int colDestino, Pieza[,] tablero)
            {
               
                if (filaDestino != Fila && colDestino != Columna)
                    return false;

                if (filaDestino == Fila)
                {
                    int inicio = Math.Min(Columna, colDestino) + 1;
                    int fin = Math.Max(Columna, colDestino);
                    for (int c = inicio; c < fin; c++)
                    {
                        if (tablero[Fila, c] != null)
                            return false;
                    }
                }
                else 
                {
                    int inicio = Math.Min(Fila, filaDestino) + 1;
                    int fin = Math.Max(Fila, filaDestino);
                    for (int f = inicio; f < fin; f++)
                    {
                        if (tablero[f, Columna] != null)
                            return false;
                    }
                }

                return true;
            }
       }

}
