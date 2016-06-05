using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DatabaseService.MASHShop.Models;

namespace DatabaseService.MASHShop.Controllers
{
    public class RegisteredUserServiceController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/RegisteredUserService
        public IQueryable<RegisteredUser> GetUsers()
        {
            return db.Users;
        }

        // GET: api/RegisteredUserService/5
        [ResponseType(typeof(RegisteredUser))]
        public async Task<IHttpActionResult> GetRegisteredUser(int id)
        {
            RegisteredUser registeredUser = await db.Users.FindAsync(id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            return Ok(registeredUser);
        }

        // PUT: api/RegisteredUserService/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRegisteredUser(int id, RegisteredUser registeredUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registeredUser.Id)
            {
                return BadRequest();
            }

            db.Entry(registeredUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisteredUserExists(id))
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

        // POST: api/RegisteredUserService
        [ResponseType(typeof(RegisteredUser))]
        public async Task<IHttpActionResult> PostRegisteredUser(RegisteredUser registeredUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(registeredUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = registeredUser.Id }, registeredUser);
        }

        // DELETE: api/RegisteredUserService/5
        [ResponseType(typeof(RegisteredUser))]
        public async Task<IHttpActionResult> DeleteRegisteredUser(int id)
        {
            RegisteredUser registeredUser = await db.Users.FindAsync(id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            db.Users.Remove(registeredUser);
            await db.SaveChangesAsync();

            return Ok(registeredUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegisteredUserExists(int id)
        {
            return db.Users.Count(e => e.Id == id) > 0;
        }
    }
}