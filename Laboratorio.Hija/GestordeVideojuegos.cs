using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratorioProg20.VideoJuegoP;

namespace LaboratorioProg20.Laboratorio.Hija
{
    internal class GestordeVideojuegos
    {
        // Clase estática GestorDeVideojuegos
        internal static class GestorDeVideojuegos
        {
            private static List<VideoJuego> listaVideojuegos = new List<VideoJuego>();

            public static void AgregarVideoJuego(VideoJuego juego)
            {
                listaVideojuegos.Add(juego);
            }

            public static List<VideoJuego> ObtenerListaVideojuegos()
            {
                return listaVideojuegos;
            }
        }
    }
}