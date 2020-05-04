using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API.Models
{
    public class OwnerDog
    {
        public int OwnerID { get; set; }
        public Owner Owner { get; set; }
        public int DogID { get; set; }
        public Dog Dog { get; set; }
    }
}
