using System;
using System.Collections.Generic;

namespace MiWebPersonal_Alessi.Models

{
    public class Datos
    
    {
        static public string Nombre = "Agustin Alessi";

        static public string  SobreMi = "Hola, Soy Agustín Alessi, me gusta trabajar en equipo y ayudar a los demas en caso de que tengan inconvenientes, estudio en la escuela secundaria ORT en la orientación de programacion";

        static public List <string> deportes = new List<string> {"futbol" , "natacion" , "tenis"};

        static public List <string> Colegios = new List<string> {"Colegio Integral Caballito" , "Ort"};
        
        static public List <string> ListaGustos {get; private set;} = new List <string> () {"Juntarme con amigos" , "Jugar al futbol" , "Dormir"};

        static public List <string> Proyectos {get; private set;} = new List <string> () {"Sala de escape" , "Que hacer en Nueva York remasterizado" , "La mueblería de mi tia"};

        static public List <string> Idiomas {get; private set;} = new List <string> () {"español" , "hebreo" , "ingles"};
        

    }
}
