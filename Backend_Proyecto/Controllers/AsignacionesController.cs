using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend_Proyecto.Models;

namespace Backend_Proyecto.Controllers
{
    public class AsignacionesController : ApiController
    {
        private BaseUTAContext db = new BaseUTAContext();
        public AsignacionesController()
        {
            // Deshabilitar la carga perezosa para prevenir referencias circulares
            db.Configuration.LazyLoadingEnabled = false;
            // Deshabilitar la creación de proxies para evitar problemas con la serialización
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Asignaciones
        public IHttpActionResult GetAsignaciones()
        {
            var asignaciones = db.Asignaciones.Include(a => a.Curso).Include(a => a.Estudiante).ToList();
            return Ok(asignaciones);
        }

        // GET: api/Asignaciones/5
        public IHttpActionResult GetAsignacion(int id)
        {
            Asignaciones asignacion = db.Asignaciones.Find(id);
            if (asignacion == null)
            {
                return NotFound();
            }

            return Ok(asignacion);
        }

        // POST: api/Asignaciones
        public IHttpActionResult PostAsignacion(Asignaciones asignacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Verificar que el estudiante existe
            var estudiante = db.Estudiantes.Find(asignacion.EstudianteID);
            if (estudiante == null)
            {
                return BadRequest("El estudiante no existe");
            }

            // Verificar que el curso existe
            var curso = db.Cursos.Find(asignacion.CursoID);
            if (curso == null)
            {
                return BadRequest("El curso no existe");
            }

            var nota = db.Notas.FirstOrDefault(n => n.EstudianteID == asignacion.EstudianteID);

            if (nota == null)
            {
                Random rnd = new Random();
                int notasCount = db.Notas.Count();
                if (notasCount > 0)
                {
                    int randomSkip = rnd.Next(notasCount);
                    nota = db.Notas.OrderBy(n => n.NotaID).Skip(randomSkip).FirstOrDefault();
                }
                else
                {
                    return BadRequest("No hay notas disponibles para asignar");
                }
            }

            // Asignar el NotaID a la asignación
            asignacion.NotaID = nota.NotaID;

            db.Asignaciones.Add(asignacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = asignacion.AsignacionID }, asignacion);
        }

        // PUT: api/Asignaciones/5
        public IHttpActionResult PutAsignacion(int id, Asignaciones asignacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != asignacion.AsignacionID)
            {
                return BadRequest();
            }

            db.Entry(asignacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                if (!AsignacionExists(id))
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

        // DELETE: api/Asignaciones/5
        public IHttpActionResult DeleteAsignacion(int id)
        {
            Asignaciones asignacion = db.Asignaciones.Find(id);
            if (asignacion == null)
            {
                return NotFound();
            }

            db.Asignaciones.Remove(asignacion);
            db.SaveChanges();

            return Ok(asignacion);
        }

        private bool AsignacionExists(int id)
        {
            return db.Asignaciones.Count(e => e.AsignacionID == id) > 0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}