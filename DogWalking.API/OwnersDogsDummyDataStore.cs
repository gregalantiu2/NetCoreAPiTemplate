using DogWalking.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API
{
    public class OwnersDogsDummyDataStore
    {
        public static OwnersDogsDummyDataStore Current { get; } = new OwnersDogsDummyDataStore();
        public List<OwnerDog> OwnerDogs { get; set; }
        public OwnersDogsDummyDataStore()
        {
            OwnerDogs = new List<OwnerDog>()
            {
                new OwnerDog()
                {
                    OwnerID = 1,
                    Owner = OwnersDummyDataStore.Current.Owners.Where(o => o.OwnerID == 1).FirstOrDefault(),
                    DogID = 1,
                    Dog = DogsDummyDataStore.Current.Dogs.Where(d => d.DogID == 1).FirstOrDefault()
                },
                new OwnerDog()
                {
                    OwnerID = 2,
                    Owner = OwnersDummyDataStore.Current.Owners.Where(o => o.OwnerID == 2).FirstOrDefault(),
                    DogID = 2,
                    Dog = DogsDummyDataStore.Current.Dogs.Where(d => d.DogID == 2).FirstOrDefault()
                },
                new OwnerDog()
                {
                    OwnerID = 1,
                    Owner = OwnersDummyDataStore.Current.Owners.Where(o => o.OwnerID == 1).FirstOrDefault(),
                    DogID = 3,
                    Dog = DogsDummyDataStore.Current.Dogs.Where(d => d.DogID == 3).FirstOrDefault()
                }
            };
        }
    }
}
