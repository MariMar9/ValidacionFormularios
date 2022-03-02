using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacionFormularios.Models
{
    public class ValidarUsuario: ValidationAttribute
    {
        #region ATRIBUTOS
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo es requerido.")]
        [MaxLength(100, ErrorMessage = "El nombre no puede contener más de 100 caracteres.")]
        [MinLength(2, ErrorMessage = "El nombre no puede contener menos de 2 caracteres.")]
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(10, 100,ErrorMessage ="La edad debe estar comprendida entre los 10 y los 100 años.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage ="Formato incorrecto.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$", ErrorMessage = "La contraseña debe tener entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula.")]
        public string Contrasenia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Compare("Contrasenia", ErrorMessage ="Las contraseñas no coinciden.")]
        public string ConfirmarContrasenia { get; set; }
        #endregion


        #region MÉTODOS
        public override bool IsValid(object usuario)
        {
            Usuario objeto = (Usuario)usuario;
            if (objeto.Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
