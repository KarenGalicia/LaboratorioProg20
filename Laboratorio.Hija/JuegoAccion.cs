using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProg20.VideoJuegoP;

namespace LaboratorioProg20.Laboratorio.Hija
{
    internal class JuegoAccion : VideoJuego
    {
        private int nivelDificultad;

        public JuegoAccion(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, int nivelDificultad)
            : base(titulo, desarrolladora, calificacion, anioLanzamiento)
        {
            NivelDificultad = nivelDificultad;
        }

        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set { nivelDificultad = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Nivel de Dificultad: " + NivelDificultad);
        }

        public void DisparoEspecial()
        {
            Console.WriteLine("¡Disparo especial activado!");
        }
    }
}