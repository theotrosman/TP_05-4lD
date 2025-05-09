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
            // Lista de muchas palabras posibles comunes
            List<string> palabrasPosibles = new List<string>
{
    "CASA", "PERRO", "GATO", "JARDIN", "CIELO", "TERRAZA", "HOGAR", "AMIGO", "FAMILIA", "TRABAJO",
    "ESCUELA", "LIBRO", "MUSICA", "PELICULA", "CINE", "CARRERA", "MOTOR", "CAMINO", "RUTA", "PAIS",
    "CIUDAD", "FIESTA", "DIA", "NOCHE", "LUNA", "SOL", "ESTRELLA", "VEHICULO", "BICICLETA", "TREN",
    "AUTOMOVIL", "AVION", "MAR", "MONTAÑA", "VALLE", "LAGO", "RIO", "CAMPO", "AGUA", "FUEGO", "TIERRA",
    "AIRE", "TRISTEZA", "FELICIDAD", "ALEGRIA", "SUEÑO", "REALIDAD", "VIAJE", "VACACIONES", "CUMPLEANOS",
    "NAVIDAD", "AÑO", "MES", "SEMANA", "HORA", "MINUTO", "SEGUNDO", "FECHA", "TIEMPO", "AMOR", "ODIO",
    "MUNDO", "TIERRA", "UNIVERSO", "CORAZON", "ALMA", "MENTE", "CUERPO", "FOTO", "VIDEO", "PAZ",
    "GUERRA", "CULTURA", "HISTORIA", "TURISMO", "AVENTURA", "LUCHA", "PELEA", "DEPORTE", "FUTBOL",
    "BALON", "JUGADOR", "ENTRENADOR", "EQUIPO", "COPA", "MEDALLA", "CAMPEON", "JUEGO", "PAREJA",
    "RELACION", "CIEGO", "SORDO", "MUDO", "PERSONA", "AMIGA", "VECINO", "EXTRAÑO", "HOMBRE",
    "MUJER", "NIÑO", "NIÑA", "ADULTO", "VIEJO", "JOVEN", "NACIMIENTO", "MUERTE", "DOLOR", "FELIZ",
    "SAD", "AGRADECIDO", "ASUSTADO", "EMOCIONADO", "SENTIMIENTO", "FELICIDAD", "CORRER", "CANTAR",
    "BAILAR", "LEER", "ESCRIBIR", "DIBUJAR", "PINTAR", "CANTANTE", "PINTOR", "ESCRITOR", "ARTISTA",
    "DESEAR", "ENAMORADO", "FLORES", "JUEGOS", "PELICULAS", "ESTUDIOS", "TRABAJO", "MOTIVACION",
    "ESTILO", "FELICIDAD", "DECISION", "CAMBIO", "OPINION", "SENTIR", "CREER", "PENSAR", "IMAGINAR"
};

            Random random = new Random();

            char[] palabraParcial = new char[palabraSecreta.Length];
            for (int i = 0; i < palabra.Length; i++) {
            palabraParcial[i] = '_';
            }
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
