using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Usuarios
    {
        /// <summary>
        /// Clase Usuarios, detalle de los usuarios de nuestra aplicacion
        /// 
        /// Todos los campos son requeridos con expeccion de telefono
        /// </summary>
        
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public double Telefono { get; set; }
        [Required]
        public int paisId { get; set; }
        public Pais pais { get; set; }
        [Required]
        public bool SerContactado { get; set; }

    }
}
