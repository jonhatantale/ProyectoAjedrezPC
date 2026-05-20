using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
        class Rey : Pieza
        {
            public Rey(string color, int fila, int columna)
                : base(color, fila, columna, color == "Blanco" ? 'R' : 'r') { }

            public override bool MovimientoValido(int filaDestino, int colDestino, Pieza[,] tablero)
            {
                int difFila = Math.Abs(filaDestino - Fila);
                int difCol = Math.Abs(colDestino - Columna);

                return difFila <= 1 && difCol <= 1 && (difFila + difCol > 0);
            }
        }
}
