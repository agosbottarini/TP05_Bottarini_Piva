public static class Escape
{
    static string[] incognitasSalas {get;set;}= new string[4]; 
    static int estadoJuego {get;set;}= 1;


    private static void InicializarJuego()
    {
        incognitasSalas[0] = "";
        incognitasSalas[1] = "";
        incognitasSalas[2] = "";
        incognitasSalas[3] = "";

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
            if(Incognita == incognitasSalas[Sala -1])
            {
                estadoJuego= estadoJuego + 1;
                return true;
            }
        }   
        
        return false;
        
    }

}