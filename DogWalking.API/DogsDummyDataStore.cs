using DogWalking.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API
{
    public class DogsDummyDataStore
    {
        public static DogsDummyDataStore Current { get; } = new DogsDummyDataStore();
        public List<DogDTO>  Dogs { get; set;}
        public DogsDummyDataStore()
        {
            Dogs = new List<DogDTO>()
            {
                new DogDTO()
                {
                    ID = 1,
                    Name = "Libby"
                },
                new DogDTO()
                {
                    ID = 2,
                    Name = "Harlan"
                }
            };
        }

    }
}
