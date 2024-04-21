using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProg20.VideoJuegoP

    {
      
        internal class VideoJuego
        {
            private string titulo;
            private string desarrolladora;
            private double calificacion;
            private int anioLanzamiento;
            private bool jugando;

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            public string Desarrolladora
            {
                get { return desarrolladora; }
                set { desarrolladora = value; }
            }

            public double Calificacion
            {
                get { return calificacion; }
                set
                {
                    //  La calificación debe estar entre 0 y 10
                    if (value < 0 || value > 10)
                    {
                        calificacion = value;
                    }
                    else
                    {
                        Console.WriteLine("La calificación debe estar entre 0 y 10");
                    }

                }
            }

            public int AnioLanzamiento
            {
                get { return anioLanzamiento; }
                set
                {
                    // Error lógico: El año de lanzamiento 
                    anioLanzamiento = value;
                }
            }

            public bool Jugando
            {
                get { return jugando; }
                set { jugando = value; }
            }


            public virtual void MostrarInformacion()
            {
                Console.WriteLine("Título: " + Titulo);
                Console.WriteLine("Desarrolladora: " + Desarrolladora);
                Console.WriteLine("Calificación: " + Calificacion);
                Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
            }

            public VideoJuego(string titulo, string desarrolladora, double calificacion, int anioLanzamiento)
            {
                Titulo = titulo;
                Desarrolladora = desarrolladora;
                Calificacion = calificacion;
                AnioLanzamiento = anioLanzamiento;
                Jugando = false;
            }


            public static void saludo()
            {
                Console.WriteLine("Hi Gamer:");
            }


            public void IniciarPartida()
            {
                jugando = true;
                Console.WriteLine("¡Partida iniciada!");
            }

            public void DetenerPartida()
            {
                // Error lógico
                Console.WriteLine("Partida detenida.");
            }

            public void TerminarJuego()
            {
                // Error lógico
                if (jugando)
                {

                    Console.WriteLine("Juego terminado.");
                }
                else
                {
                    Console.WriteLine("No hay partida en curso.");
                }
            }

        }
    }

