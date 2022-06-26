using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.ModelsViews;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {
        private readonly WebAPIContext _context;

        public ActividadesController(WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Actividades
        [HttpGet]
        public  ActionResult<IEnumerable<VMActividades>> GetActividades()
        {
            var actividades = _context.Actividades.Include(n => n.usuarios).ToList();
            var VMAct = (from act in actividades
                         select new VMActividades
                         {
                             FechaActividad = act.Create_date,
                             NombreCompleto = act.usuarios.Nombre + " " + act.usuarios.Apellido,
                             DetalleActividad = act.Actividad
                         }).ToList();



            return  VMAct.OrderBy(n => n.FechaActividad).ToList();
        }

        //// GET: api/Actividades/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Actividades>> GetActividades(int id)
        //{
        //    var actividades = await _context.Actividades.FindAsync(id);

        //    if (actividades == null)
        //    {
        //        return NotFound();
        //    }

        //    return actividades;
        //}

        //// PUT: api/Actividades/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutActividades(int id, Actividades actividades)
        //{
        //    if (id != actividades.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(actividades).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ActividadesExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Actividades
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Actividades>> PostActividades(Actividades actividades)
        //{
        //    _context.Actividades.Add(actividades);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetActividades", new { id = actividades.Id }, actividades);
        //}

        //// DELETE: api/Actividades/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Actividades>> DeleteActividades(int id)
        //{
        //    var actividades = await _context.Actividades.FindAsync(id);
        //    if (actividades == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Actividades.Remove(actividades);
        //    await _context.SaveChangesAsync();

        //    return actividades;
        //}

        //private bool ActividadesExists(int id)
        //{
        //    return _context.Actividades.Any(e => e.Id == id);
        //}
    }
}
