using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioAnalisis.Entidades;
using System.Data.Entity;

namespace UsuarioAnalisis.DAL
{
    class ContextoC : DbContext
    {
        public DbSet<Cargos> Cargos { get; set; }

        public ContextoC() : base("ConStr")
        { }
    }
}
