using System;
using System.Collections.Generic;

namespace MiWebPersonal_Alessi.Models

{
    public class Datos
    {
        static public string Nombre = "Agustin Alessi";

        static public string  SobreMi = "Hola, Soy Agustín Alessi, me gusta trabajar en equipo y ayudar a los demas en caso de que tengan inconvenientes, estudio en la escuela secundaria ORT en la orientación de programacion";

        static public List <string> deportes = new List<string> {"futbol" , "natacion" , "tenis"};
        static public List <string> Colegios = new List<string> {"Integral Caballito" , "Ort"};
        
        static public List <string> ListaGustos {get; private set;} = new List <string> () {"Juntarme con amigos" , "Jugar al futbol" , "Dormir"};

    }

    public class Trabajos
    
    {
        public class proyecto1 
        {
            static public string NombreProyecto = "Lugares para visitar en Nueva York";

            static public string enlace = "Lugares para visitar en Nueva York (66874bfeddec6cbbdde8bf50--spiffy-tanuki-9d25a6.netlify.app)";

            static public string descripcion1 = "Diseñé un programa en html + css para la gente que no sepa que lugar visitar en Nueva York";
        }

        public class proyecto2 
        {
            static public string NombreProyecto = "Museadum";

            static public string descripcion1 = "Diseñé un programa en html + css para crear una pagina para un museo de dinosaurios, para más información, contactame";
        }

        public class proyecto3 
        {
            static public string NombreProyecto = "Sala de Escape";

            static public string descripcion1 = "Diseñé un programa en mvc + html + css con 2 integrantes para crear una sala de escape, para más información, contactame";
        }


    }
}
