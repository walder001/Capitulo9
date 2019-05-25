using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9.Capitulo10.Entidades
{
    /// <summary>
    /// Clase para la informacion de un estudiante
    /// </summary>
    public class InformacionEstudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNaciminete { get; set; }
        public string Grado { get; set; }
        public string NombrePadre { get; set; }
        public string TelefonoPadre { get; set; }
        public string NombreMadre { get; set; }
        public string TelefonoMadre { get; set; }

        /// <summary>
        /// Constructor vacio de la clase
        /// </summary>
        public InformacionEstudiante()
        {
            IdEstudiante = 0;
            Nombres = string.Empty;
            Direccion = string.Empty;
            FechaNaciminete =DateTime.Now;
            Grado =string.Empty;
            NombrePadre = string.Empty;
            TelefonoPadre =string.Empty;
            NombreMadre = string.Empty;
            TelefonoMadre =string.Empty;
        }


        /// <summary>
        ///Constructor cin parametro de la clase 
        /// </summary>
        /// <param name="idEstudiante"></param>
        /// <param name="nombres"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNaciminete"></param>
        /// <param name="grado"></param>
        /// <param name="nombrePadre"></param>
        /// <param name="telefonoPadre"></param>
        /// <param name="nombreMadre"></param>
        /// <param name="telefonoMadre"></param>
        public InformacionEstudiante(int idEstudiante, string nombres, string apellidos, DateTime fechaNaciminete, string grado, string nombrePadre, string telefonoPadre, string nombreMadre, string telefonoMadre)
        {
            IdEstudiante = idEstudiante;
            Nombres = nombres;
            Direccion = apellidos;
            FechaNaciminete = fechaNaciminete;
            Grado = grado ;
            NombrePadre = nombrePadre;
            TelefonoPadre = telefonoPadre ;
            NombreMadre = nombreMadre;
            TelefonoMadre = telefonoMadre;
        }
    }
}
