using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacionFormularios.Data;
using ValidacionFormularios.Models;

namespace ValidacionFormularios.Repositories
{
    public class RepositoryUsuarios
    {
        private UsuariosContext context;

        public RepositoryUsuarios(UsuariosContext context)
        {
            this.context = context;
        }

        public void CreateUsuario(string nombre, string apellidos, int edad, string email, string contrasenia, string confirmarContrasenia)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = nombre;
            nuevoUsuario.Apellidos = apellidos;
            nuevoUsuario.Edad = edad;
            nuevoUsuario.Email = email;
            nuevoUsuario.Contrasenia = contrasenia;
            nuevoUsuario.ConfirmarContrasenia = confirmarContrasenia;
            this.context.Usuarios.Add(nuevoUsuario);
            this.context.SaveChanges();
        }

        public Usuario FindUsuario(string email)
        {
            return this.context.Usuarios.FirstOrDefault(x => x.Email == email);
        }

    }
}
