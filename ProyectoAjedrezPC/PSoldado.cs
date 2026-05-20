using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
        class Soldado : Pieza
        {
            public Soldado(string color, int fila, int columna)
                : base(color, fila, columna, color == "Blanco" ? 'S' : 's') { }

            public override bool MovimientoValido(int filaDestino, int colDestino, Pieza[,] tablero)
            {
                int direccion = (Color == "Blanco") ? -1 : 1;
                int difFila = filaDestino - Fila;
                int difCol = Math.Abs(colDestino - Columna);

                if (difFila == direccion && difCol == 0 && tablero[filaDestino, colDestino] == null)
                    return true;

                if (difFila == direccion && difCol == 1 && tablero[filaDestino, colDestino] != null
                    && tablero[filaDestino, colDestino].Color != Color)
                    return true;

                return false;
            }
        }

}
