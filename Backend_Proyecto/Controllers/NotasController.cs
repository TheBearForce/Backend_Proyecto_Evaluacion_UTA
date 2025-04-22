using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Backend_Proyecto.Models;

namespace Backend_Proyecto.Controllers
{
    public class NotasApiController : ApiController
    {
        private BaseUTAContext db = new BaseUTAContext();

        public NotasApiController()
        {
            // Deshabilitar la carga perezosa para prevenir referencias circulares
            db.Configuration.LazyLoadingEnabled = false;
            // Deshabilitar la creación de proxies para evitar problemas con la serialización
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/NotasApi
        public IHttpActionResult GetNotas()
        {
            var notas = db.Notas
                .Include(n => n.Estudiante)
                .ToList(); // Materializamos la consulta con ToList()

            return Ok(notas);
        }

        // GET: api/NotasApi/5
        [ResponseType(typeof(Notas))]
        public IHttpActionResult GetNotas(int id)
        {
            Notas notas = db.Notas
                .Include(n => n.Estudiante)
                .FirstOrDefault(n => n.NotaID == id);

            if (notas == null)
            {
                return NotFound();
            }

            return Ok(notas);
        }

        // GET: api/NotasApi/Estudiante/5
        [Route("api/NotasApi/Estudiante/{id}")]
        public IHttpActionResult GetNotasByEstudiante(int id)
        {
            var notas = db.Notas
                .Where(n => n.EstudianteID == id)
                .ToList();

            if (notas == null || notas.Count == 0)
            {
                return NotFound();
            }

            return Ok(notas);
        }

        // PUT: api/NotasApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotas(int id, Notas notas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notas.NotaID)
            {
                return BadRequest();
            }

            db.Entry(notas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/NotasApi
        [ResponseType(typeof(Notas))]
        public IHttpActionResult PostNotas(Notas notas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notas.Add(notas);
            db.SaveChanges();

            // Limpiar las relaciones para evitar problemas de serialización
            notas = db.Notas
                .Include(n => n.Estudiante)
                .FirstOrDefault(n => n.NotaID == notas.NotaID);

            return CreatedAtRoute("DefaultApi", new { id = notas.NotaID }, notas);
        }

        // DELETE: api/NotasApi/5
        [ResponseType(typeof(Notas))]
        public IHttpActionResult DeleteNotas(int id)
        {
            Notas notas = db.Notas.Find(id);
            if (notas == null)
            {
                return NotFound();
            }

            db.Notas.Remove(notas);
            db.SaveChanges();

            return Ok(notas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotasExists(int id)
        {
            return db.Notas.Count(e => e.NotaID == id) > 0;
        }
    }
}