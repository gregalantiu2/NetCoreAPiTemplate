﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetDogs()
        {
            //200
            return Ok(DogsDummyDataStore.Current.Dogs);
        }
        [HttpGet("{id}")]
        public IActionResult GetDog(int id)
        {
            var dogReturn = DogsDummyDataStore.Current.Dogs.FirstOrDefault(d => d.DogID == id);

            if (dogReturn == null)
            {
                //404
                return NotFound();
            }

            //200
            return Ok(dogReturn); 
        }
    }
}
