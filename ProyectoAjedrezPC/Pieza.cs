using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
        abstract class Pieza
        {
            public string Color { get; set; } 
            public int Fila { get; set; }
            public int Columna { get; set; }
            public char Simbolo { get; set; }      

            public Pieza(string color, int fila, int columna, char simbolo)
            {
                Color = color;
                Fila = fila;
                Columna = columna;
                Simbolo = simbolo;
            }
        
            public abstract bool MovimientoValido(int filaDestino, int colDestino, Pieza[,] tablero);
        }
}
