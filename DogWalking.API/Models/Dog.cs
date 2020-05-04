using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API.Models
{
    public class Dog
    {
        public int DogID { get; set; }
        public string Name { get; set; }
        public ICollection<OwnerDog> OwnerDogs { get; set; }
    }
}
