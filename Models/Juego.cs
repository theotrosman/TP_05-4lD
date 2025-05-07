public static class Juego
{
    private static string palabraSecreta = "PROGRAMACION";
    private static char[] palabraParcial;
    private static List<char> letrasUsadas = new List<char>();
    private static int intentos = 0;
    private static bool finalizado = false;
    private static bool gano = false;

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
        char letra = char.ToUpper(letraarriesgada);
        if (letrasUsadas.Contains(letra) || finalizado)
            return;

        letrasUsadas.Add(letra);
        bool acerto = false;

        for (int i = 0; i < palabraSecreta.Length; i++)
        {
            if (palabraSecreta[i] == letra)
            {
                palabraParcial[i] = letra;
                acerto = true;
            }
        }

        if (!acerto)
            intentos++;

        if (!new string(palabraParcial).Contains('_'))
        {
            finalizado = true;
            gano = true;
        }

        if (intentos >= 6)
            finalizado = true;
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
            if (intentos >= 6)
                finalizado = true;
        }
    }
}
