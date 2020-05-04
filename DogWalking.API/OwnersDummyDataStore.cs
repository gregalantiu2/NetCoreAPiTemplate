using DogWalking.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API
{
    public class OwnersDummyDataStore
    {
        public static OwnersDummyDataStore Current { get; } = new OwnersDummyDataStore();
        public List<Owner> Owners { get; set; }
        public OwnersDummyDataStore()
        {
            Owners = new List<Owner>()
            {
                new Owner()
                {
                    OwnerID = 1,
                    FirstName = "Greg",
                    LastName = "Tiu",
                    OwnerDogs = OwnerDogDummyDataStore.Current.OwnerDogs
                },
                new Owner()
                {
                    OwnerID = 2,
                    FirstName = "Emmanuel",
                    LastName = "Ruvalcaba",
                    OwnerDogs = OwnerDogDummyDataStore.Current.OwnerDogs
                }
            };
        }
    }
}
