using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using ApiHotels.Models;

namespace ApiHotels.Controllers
{
    public class HotelsController : ApiController
    {
        private Modelo db = new Modelo();

        // GET: api/Hotels
        public IQueryable<Hotel> GetHotel()
        {
            return db.Hotel;
        }

        //GET: api/HotelDetails/{id}
        [HttpGet]
        [Route("api/HotelDetails/{id}")]
        public HttpResponseMessage GetHotelDetails(int id)
        {
            Hotel h = db.Hotel.Find(id);

            if (h == null) return Request.CreateResponse(HttpStatusCode.NotFound);

            return Request.CreateResponse(HttpStatusCode.OK, h.HotelDetail);
        }

        [HttpPost]
        [Route("api/Hotel/SetDestacado")]
        public HttpResponseMessage PostAddDestacado(int id, bool Destacado)
        {
            Hotel h = db.Hotel.Find(id);

            if (h == null) return Request.CreateResponse(HttpStatusCode.NotFound);

            h.Destacado = Destacado;

            db.Hotel.AddOrUpdate(h);

            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, h);
        }


    }
}