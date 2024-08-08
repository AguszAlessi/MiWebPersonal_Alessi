using System;
using System.Collections.Generic;
namespace MiWebPersonal_Alessi.Models

{
    public class Datos
    
    {
        static public string  SobreMi = "Hola, Soy Agustín Alessi, me gusta trabajar en equipo y ayudar a los demas en caso de que tengan inconvenientes, estudio en la escuela secundaria ORT en la orientación de programacion";
        static public List <string> deportes = new List<string> {"futbol" , "natacion" , "tenis"};
        static public List <string> Colegios = new List<string> { "Jardin del Girasol" ,"Colegio Integral Caballito" , "Ort"};
        static public List <string> comidas = new List<string> { "sushi" ,"Pizza" , "Hamburguesa"};
        static public List <string> Proyectos {get; private set;} = new List <string> () {"Que hacer en Nueva York" , "Que hacer en Nueva York remasterizado" , "La mueblería de mi tia"};
        static public List <string> Idiomas {get; private set;} = new List <string> () {"español" , "hebreo" , "ingles"};
        static public string descproyecto1 = "En este proyecto hecho con un compañero, decidimos crear una página web para ayudar a personas que no saben que hacer en Nueva York, en este, aplicamos html + css. Si deseas ver el proyecto, apreta el botón de abajo: ";
        static public string descproyecto2 = "En este proyecto hecho con un compañero, decidimos crear una página web para una mueblería en este,el usuario podía buscar mediante un formulario, aplicamos unicamente html Si deseas ver el proyecto, apreta el botón de abajo: ";
        static public string descproyecto3 = "En este proyecto hecho con un compañero, decidimos crear una página web para ayudar a personas que no saben que hacer en Nueva York, en este, unicamente html. Si deseas ver el proyecto, apreta el botón de abajo: ";
    }   
}
