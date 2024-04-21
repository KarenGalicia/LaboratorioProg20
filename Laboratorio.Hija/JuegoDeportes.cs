using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProg20.VideoJuegoP;

namespace LaboratorioProg20.Laboratorio.Hija
{
    internal class JuegoDeportes:VideoJuego
    {
    
        private string deporte;

        public JuegoDeportes(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, string deporte)
            : base(titulo, desarrolladora, calificacion, anioLanzamiento) => Deporte = deporte;

        public string Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Deporte: " + Deporte);
        }

        public void MostrarReglas()
        {
            Console.WriteLine("Mostrando reglas del deporte...");
        }
    }
}
