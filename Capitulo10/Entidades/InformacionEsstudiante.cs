using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Capitulo10.Entidades
{
    public class InformacionEsstudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNaciminete { get; set; }
        public string Grado { get; set; }
        public string NombrePadre { get; set; }
        public string TelefonoPadre { get; set; }
        public string NombreMadre { get; set; }
        public string TelefonoMadre { get; set; }

        public InformacionEsstudiante()
        {
            IdEstudiante = 0;
            Nombre = "";
            Apellidos = "";
            FechaNaciminete =DateTime.Now;
            Grado ="";
            NombrePadre ="" ;
            TelefonoPadre ="";
            NombreMadre = "";
            TelefonoMadre ="";
        }

        public InformacionEsstudiante(int idEstudiante, string nombre, string apellidos, DateTime fechaNaciminete, string grado, string nombrePadre, string telefonoPadre, string nombreMadre, string telefonoMadre)
        {
            IdEstudiante = idEstudiante;
            Nombre = nombre ;
            Apellidos = apellidos;
            FechaNaciminete = fechaNaciminete;
            Grado = grado ;
            NombrePadre = nombrePadre;
            TelefonoPadre = telefonoPadre ;
            NombreMadre = nombreMadre;
            TelefonoMadre = telefonoMadre;
        }
    }
}
