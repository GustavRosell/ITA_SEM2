using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modul14.Server.Repositories;

using modul14.Shared;

namespace webshop.Server.Controllers
{
    [ApiController]
    [Route("api/bike")]
    public class BikeController : ControllerBase
    {

        private IBikeRepository bikeRepo;

        public BikeController(IBikeRepository bikeRepo) {
            this.bikeRepo = bikeRepo;
        }

        [HttpGet]
        public IEnumerable<BEBike> Get()
        {
            return bikeRepo.GetAll();
        }

        [HttpPost]
        public void Add(BEBike bike) {
            bikeRepo.Add(bike);
        }


        [HttpDelete]
        [Route("{id:int}")]
        public void Delete(int id)
        {
            bikeRepo.DeleteById(id);
        }





    }
}

