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
    public class EstudiantesApiController : ApiController
    {
        private BaseUTAContext db = new BaseUTAContext();

        public EstudiantesApiController()
        {
            // Deshabilitar la carga perezosa para prevenir referencias circulares
            db.Configuration.LazyLoadingEnabled = false;
            // Deshabilitar la creación de proxies para evitar problemas con la serialización
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/EstudiantesApi
        public IHttpActionResult GetEstudiantes()
        {
            var estudiantes = db.Estudiantes
                .Include(e => e.Carrera)
                .ToList(); // Materializamos la consulta con ToList()

            return Ok(estudiantes);
        }

        // GET: api/EstudiantesApi/5
        [ResponseType(typeof(Estudiantes))]
        public IHttpActionResult GetEstudiantes(int id)
        {
            Estudiantes estudiantes = db.Estudiantes
                .Include(e => e.Carrera)
                .Include(e => e.Asignaciones)
                .Include(e => e.Notas)
                .FirstOrDefault(e => e.EstudianteID == id);

            if (estudiantes == null)
            {
                return NotFound();
            }

            return Ok(estudiantes);
        }

        // PUT: api/EstudiantesApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEstudiantes(int id, Estudiantes estudiantes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estudiantes.EstudianteID)
            {
                return BadRequest();
            }

            db.Entry(estudiantes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudiantesExists(id))
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

        // POST: api/EstudiantesApi
        [ResponseType(typeof(Estudiantes))]
        public IHttpActionResult PostEstudiantes(Estudiantes estudiantes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            estudiantes.NotaID = null;

            db.Estudiantes.Add(estudiantes);
            db.SaveChanges();

            estudiantes = db.Estudiantes
                .Include(e => e.Carrera)
                .FirstOrDefault(e => e.EstudianteID == estudiantes.EstudianteID);

            return CreatedAtRoute("DefaultApi", new { id = estudiantes.EstudianteID }, estudiantes);
        }

        // DELETE: api/EstudiantesApi/5
        [ResponseType(typeof(Estudiantes))]
        public IHttpActionResult DeleteEstudiantes(int id)
        {
            Estudiantes estudiantes = db.Estudiantes.Find(id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            db.Estudiantes.Remove(estudiantes);
            db.SaveChanges();

            return Ok(estudiantes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EstudiantesExists(int id)
        {
            return db.Estudiantes.Count(e => e.EstudianteID == id) > 0;
        }
    }
}