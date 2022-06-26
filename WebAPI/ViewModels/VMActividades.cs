using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.ModelsViews
{
    public class VMActividades 
    {
        public VMActividades() { }

        public VMActividades(Actividades actividades, Usuarios usuarios) {
            FechaActividad = actividades.Create_date;
            NombreCompleto = usuarios.Nombre + " " + usuarios.Apellido;
            DetalleActividad = actividades.Actividad;
        
        }
        public DateTime FechaActividad { get; set; }
        public string NombreCompleto { get; set; }
        public string DetalleActividad { get; set; }
    }
}
