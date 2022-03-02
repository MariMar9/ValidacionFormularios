using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacionFormularios.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        #region ATRIBUTOS
        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }
            
        [Column("edad")]
        public int Edad { get; set; }
            
        [Key]
        [Column("email")]
        public string Email { get; set; }
            
        [Column("contrasenia")]
        public string Contrasenia { get; set; }

        [Column("confirmarContrasenia")]
        public string ConfirmarContrasenia { get; set; }
        #endregion
    }
}
