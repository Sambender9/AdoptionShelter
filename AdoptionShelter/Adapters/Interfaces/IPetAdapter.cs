using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.data.models;

namespace AdoptionShelter.Adapters.Interfaces
{
    public interface IPetAdapter//If you dont make this public then it is private by default
    {
        List<Pet> GetListPets();//If we don't obey this contract then we will always have errors.
        List<Shelter> GetListShelters();
        Pet GetPet(int id);
        void AddPet(Pet pet);
        void EditPet(Pet pet);
        void AddShelter(Shelter shelter);
        Pet GetPetByName(string Pet);
        void AdoptPet(int id);
        void DeleteShelter(int id);

       
    }
}
