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
        public List<Dog>  Dogs { get; set;}
        public DogsDummyDataStore()
        {
            Dogs = new List<Dog>()
            {
                new Dog()
                {
                    DogID = 1,
                    Name = "Libby",
                    OwnerDogs = OwnerDogDummyDataStore.Current.OwnerDogs
                },
                new Dog()
                {
                    DogID = 2,
                    Name = "Lobo",
                    OwnerDogs = OwnerDogDummyDataStore.Current.OwnerDogs
                },
                new Dog()
                {
                    DogID = 3,
                    Name = "Harlan",
                    OwnerDogs = OwnerDogDummyDataStore.Current.OwnerDogs
                }
            };
        }

    }
}
