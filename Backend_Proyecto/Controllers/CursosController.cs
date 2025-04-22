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

namespace Backend_Proyecto.Controllers.API
{
    public class CursosApiController : ApiController
    {
        private BaseUTAContext db = new BaseUTAContext();
        public CursosApiController()
        {
            // Deshabilitar la carga perezosa para prevenir referencias circulares
            db.Configuration.LazyLoadingEnabled = false;
            // Deshabilitar la creación de proxies para evitar problemas con la serialización
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/CursosApi
        public IHttpActionResult GetCursos()
        {
            return Ok(db.Cursos.ToList());
        }

        // GET: api/CursosApi/5
        [ResponseType(typeof(Cursos))]
        public IHttpActionResult GetCursos(int id)
        {
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return NotFound();
            }

            return Ok(cursos);
        }

        // PUT: api/CursosApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCursos(int id, Cursos cursos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cursos.CursoID)
            {
                return BadRequest();
            }

            db.Entry(cursos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursosExists(id))
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

        // POST: api/CursosApi
        [ResponseType(typeof(Cursos))]
        public IHttpActionResult PostCursos(Cursos cursos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cursos.Add(cursos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cursos.CursoID }, cursos);
        }

        // DELETE: api/CursosApi/5
        [ResponseType(typeof(Cursos))]
        public IHttpActionResult DeleteCursos(int id)
        {
            Cursos cursos = db.Cursos.Find(id);
            if (cursos == null)
            {
                return NotFound();
            }

            db.Cursos.Remove(cursos);
            db.SaveChanges();

            return Ok(cursos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CursosExists(int id)
        {
            return db.Cursos.Count(e => e.CursoID == id) > 0;
        }
    }
}