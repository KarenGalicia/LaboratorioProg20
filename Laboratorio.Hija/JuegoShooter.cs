using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProg20.VideoJuegoP;

namespace LaboratorioProg20.Laboratorio.Hija
{
    internal class JuegoShooter: VideoJuego
    {
 
        private int municionTotal;

        public JuegoShooter(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, int municionTotal)
            : base(titulo, desarrolladora, calificacion, anioLanzamiento)
        {
            MunicionTotal = municionTotal;
        }

        public int MunicionTotal
        {
            get { return municionTotal; }
            set { municionTotal = value; }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Munición Total: " + MunicionTotal);
        }

        public void RecargarMunicion()
        {
            Console.WriteLine("Recargando munición...");
        }
    }
}
