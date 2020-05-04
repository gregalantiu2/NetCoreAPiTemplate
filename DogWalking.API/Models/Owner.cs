using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalking.API.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + LastName; } }
        public ICollection<OwnerDog> OwnerDogs { get; set; }
    }
}
