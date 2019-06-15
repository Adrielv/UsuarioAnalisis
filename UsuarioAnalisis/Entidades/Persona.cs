using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UsuarioAnalisis.Entidades
{
   public class Persona
    {
       [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
       
        public string Email { get; set; }
        public string NivelUsuario { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Persona()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
