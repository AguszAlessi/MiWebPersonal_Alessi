using System;
using System.Collections.Generic;

namespace MiWebPersonal_Alessi.Models

{
    public class SobreMi
    
    {
     
        static public List <string> deportes = new List<string> {"futbol" , "natacion" , "tenis"};

        static public List <string> Colegios = new List<string> {"Colegio Integral Caballito" , "Ort"};
        
        static public List <string> ListaGustos {get; private set;} = new List <string> () {"Juntarme con amigos" , "Jugar al futbol" , "Dormir"};

        static public List <string> Idiomas {get; private set;} = new List <string> () {"español" , "hebreo" , "ingles"};

    }
}
