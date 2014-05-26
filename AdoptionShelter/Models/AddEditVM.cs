using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.data.models;

namespace AdoptionShelter.Models
{
    public class AddEditVM
    {
        public Pet Pet                  { get; set; }
        public Shelter Shelter          { get; set; }
        public string Title             { get; set; }
        public string ButtonMessage     { get; set; }
    }
}