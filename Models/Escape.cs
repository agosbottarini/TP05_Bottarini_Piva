public static class Escape
{
    static string[] incognitasSalas {get;set;} 
    static int estadoJuego {get;set;}= 1;


    private static void InicializarJuego()
    {
        incognitasSalas = new string[4]; 
        incognitasSalas[0] = "COMPUTADORA";
        incognitasSalas[1] = "38";
        incognitasSalas[2] = "6";
        incognitasSalas[3] = "LLAVE";

    }
    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        
       
        if(incognitasSalas == null)
        {
            InicializarJuego();
        }

        if(Sala == estadoJuego)
        {
            if(Incognita.ToUpper() == incognitasSalas[Sala -1])
            {
                estadoJuego= estadoJuego + 1;
                return true;
            }
        }   
        
        return false;
        
    }

}