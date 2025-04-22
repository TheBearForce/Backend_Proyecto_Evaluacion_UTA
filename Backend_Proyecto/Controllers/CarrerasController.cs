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
    public class CarrerasAPIController : ApiController
    {
        private BaseUTAContext db = new BaseUTAContext();

        public CarrerasAPIController()
        {
            // Deshabilitar la carga perezosa para prevenir referencias circulares
            db.Configuration.LazyLoadingEnabled = false;
            // Deshabilitar la creación de proxies para evitar problemas con la serialización
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/CarrerasAPI
        public IQueryable<Carreras> GetCarreras()
        {
            return db.Carreras;
        }

        // GET: api/CarrerasAPI/5
        [ResponseType(typeof(Carreras))]
        public IHttpActionResult GetCarreras(int id)
        {
            Carreras carreras = db.Carreras.Find(id);
            if (carreras == null)
            {
                return NotFound();
            }

            return Ok(carreras);
        }

        // PUT: api/CarrerasAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarreras(int id, Carreras carreras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carreras.CarreraID)
            {
                return BadRequest();
            }

            db.Entry(carreras).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrerasExists(id))
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

        // POST: api/CarrerasAPI
        [ResponseType(typeof(Carreras))]
        public IHttpActionResult PostCarreras(Carreras carreras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carreras.Add(carreras);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carreras.CarreraID }, carreras);
        }

        // DELETE: api/CarrerasAPI/5
        [ResponseType(typeof(Carreras))]
        public IHttpActionResult DeleteCarreras(int id)
        {
            Carreras carreras = db.Carreras.Find(id);
            if (carreras == null)
            {
                return NotFound();
            }

            db.Carreras.Remove(carreras);
            db.SaveChanges();

            return Ok(carreras);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarrerasExists(int id)
        {
            return db.Carreras.Count(e => e.CarreraID == id) > 0;
        }
    }
}