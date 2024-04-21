using System;
using LaboratorioProg20.Laboratorio.Hija;

namespace TuNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Mostrar información de Juego de Acción");
                Console.WriteLine("2. Mostrar información de Juego de Deportes");
                Console.WriteLine("3. Mostrar información de Juego Shooter");
                Console.WriteLine("4. Salir");

                Console.Write("Ingrese su opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarInformacionJuegoAccion();
                        break;
                    case "2":
                        MostrarInformacionJuegoDeportes();
                        break;
                    case "3":
                        MostrarInformacionJuegoShooter();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }

        private static void MostrarInformacionJuegoShooter()
        {
            throw new NotImplementedException();
        }

        static void MostrarInformacionJuegoAccion()
        {
            JuegoAccion juegoAccion = new JuegoAccion("Call of Duty: Modern Warfare", "Activision", 9.2, 2019, 5);
            juegoAccion.MostrarInformacion();
            juegoAccion.DisparoEspecial(); // Llamada a la función específica de JuegoAccion
        }

        static void MostrarInformacionJuegoDeportes()
        {
            JuegoDeportes juegoDeportes = new JuegoDeportes("FIFA 22", "EA Sports", 8.7, 2021, "Fútbol");
            juegoDeportes.MostrarInformacion();

                JuegoShooter juegoShooter = new JuegoShooter("Overwatch", "Blizzard Entertainment", 8.5, 2016, 200);
                juegoShooter.MostrarInformacion();
                juegoShooter.MostrarTablaLideres(); // Llamada a la función específica de JuegoShooter
                juegoShooter.Disparar();
        }
        }
    }
   