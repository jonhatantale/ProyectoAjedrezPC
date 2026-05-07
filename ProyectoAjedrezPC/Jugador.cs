using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
    internal class Jugador
    {
        public string nombre { get; set; }
        public int puntaje { get; set; } 
        public string color { get; set; } 

        public Jugador(string nom, string col)
        {
            nombre = nom;
            color = col;
            puntaje = 0;
        }

        public void SumarPuntos(Pieza piezaCapturada)
        {
            puntaje += 10;
            if (piezaCapturada is Rey)
            {
                puntaje += 50;
            }
        }
    }
}
