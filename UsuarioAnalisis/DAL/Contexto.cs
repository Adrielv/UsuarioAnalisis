using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioAnalisis.Entidades;
using System.Data.Entity;

namespace UsuarioAnalisis.DAL
{
    public class Contexto : DbContext 
 
    {
        public DbSet<Persona> Persona { get; set; }

        public DbSet<TipoAnalisis> TipoAnalisis { get; set; }

        public DbSet<Analisis> Analisis { get; set; }

        public Contexto() : base ("ConStr")
        { }
    }
}
