using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Pais
    {
        /// <summary>
        /// Clase Pais, controla con Id y Nombre los pais a los cuales perteneces los usiarios
        /// </summary>

        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
