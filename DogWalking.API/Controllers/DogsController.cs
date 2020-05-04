using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API.Controllers
{
    [ApiController]
    [Route("api/Dogs")]
    public class DogsController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetDogs()
        {
            return new JsonResult(DogsDummyDataStore.Current.Dogs);
        }
        [HttpGet("{id}")]
        public JsonResult GetDog(int id)
        {
            return new JsonResult(DogsDummyDataStore.Current.Dogs.FirstOrDefault(d => d.ID == id));
        }
    }
}
