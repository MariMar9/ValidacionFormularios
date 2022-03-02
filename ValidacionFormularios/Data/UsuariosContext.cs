using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionFormularios.Models;

namespace ValidacionFormularios.Data
{
    public class UsuariosContext: DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

