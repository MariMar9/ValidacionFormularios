using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacionFormularios.Models
{
    public class Usuario
    {
        [Required]
        [StringLength(100, ErrorMessage="El nombre no puede contener más de 100 caracteres", MinimumLength = 2)]
        public String Nombre { get; set; }

        public String Apellidos { get; set; }

        [Required]
        public int Edad { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public String Contrasenia { get; set; }

        [Required]
        public String ConfirmarContrasenia { get; set; }
    }
}
