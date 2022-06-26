using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Actividades
    {
        /// <summary>
        /// Clase Actividades, detalle (log) de las actividades realizadas por el usuario.
        /// 
        /// Todos los campos son obligatorios
        /// </summary>
         
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Create_date { get; set; }
        [Required]
        public int usuariosId { get; set; }
        public Usuarios usuarios { get; set; }
        [Required]
        public string Actividad { get; set; }

    }
}
