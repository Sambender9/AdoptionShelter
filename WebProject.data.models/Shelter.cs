using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.data.models
{
    public class Shelter
    {
        public int       Id         { get; set; }
        public string    Name       { get; set; }
        public string    Address    { get; set; }
        public string    ShelterPic { get; set; }
        public List<Pet> Pets       { get; set; }
    }
}
