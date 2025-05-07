using System;
using System.Collections.Generic;

namespace TP_05_4ID.Models
{
    public static class Juego
    {
        private static string palabraSecreta = "PROGRAMACION";
        private static char[] palabraParcial;
        private static List<char> letrasUsadas;
        private static int intentos;
        private static bool finalizado;
        private static bool gano;

        public static void NuevoJuego()
        {
            palabraSecreta = "PROGRAMACION";
            palabraParcial = new string('_', palabraSecreta.Length).ToCharArray();
            letrasUsadas = new List<char>();
            intentos = 0;
            finalizado = false;
            gano = false;
        }

        public static string GetPalabraParcial() => string.Join(" ", palabraParcial);

        public static List<char> GetLetrasUsadas() => letrasUsadas;

        public static bool JuegoFinalizado() => finalizado;

        public static int GetIntentos() => intentos;

        public static bool Gano() => gano;

        public static string GetPalabraSecreta() => palabraSecreta;

        public static void ArriesgarLetra(char letraarriesgada)
        {
            letraarriesgada = char.ToUpper(letraarriesgada);

            if (letrasUsadas.Contains(letraarriesgada) || finalizado) return;

            letrasUsadas.Add(letraarriesgada);
            bool acerto = false;

            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letraarriesgada)
                {
                    palabraParcial[i] = letraarriesgada;
                    acerto = true;
                }
            }

            if (!acerto) intentos++;

            if (!new string(palabraParcial).Contains('_'))
            {
                finalizado = true;
                gano = true;
            }
            if (intentos >= 6) finalizado = true;
        }
        public static void ArriesgarPalabra(string palabraarriesgada)
        {
            if (finalizado) return;

            string palabra = palabraarriesgada.ToUpper();
            if (palabra == palabraSecreta)
            {
                palabraParcial = palabraSecreta.ToCharArray();
                finalizado = true;
                gano = true;
            }
            else
            {
                intentos += 2;
                if (intentos >= 6) finalizado = true;
            }
        }
    }
}
