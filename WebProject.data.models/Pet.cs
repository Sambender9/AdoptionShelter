using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.data.models
{
    public class Pet//This has to be public because everything inherits from it
    {
        //Access Modifier, data type, prop, getter and setters
        public int               Id         { get; set; }
        public string            Name       { get; set; }
        public string            Picture    { get; set; }
        public int               Age        { get; set; }
        public virtual Shelter   Shelter    { get; set; }
        public int               ShelterId  { get; set; }
        public string            Breed      { get; set; }
        
    }
}
