using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAjedrezPC
{
    internal class Puntaje
    {
        public string ganador { get; set; }
        public int puntMax { get; set; }
        public bool registro { get; set; }

        public Puntaje()
        {
            registro = false;
            puntMax = 0;
            ganador = "";
        }

        public void ActRecord(string nombre, int puntaje)
        {
            if (registro == false || puntaje > puntMax)
            {
                ganador = nombre;
                puntMax = puntaje;
                registro = true;
            }
        }

        public void MostrarRecord()
        {
            if (registro == false)
            {
                Console.WriteLine("No existen puntajes registrados");
            }
            else
            {
                Console.WriteLine("Mejor jugador: " + ganador + " con: " + puntMax + " puntos" );
            }
        }

    }
}
