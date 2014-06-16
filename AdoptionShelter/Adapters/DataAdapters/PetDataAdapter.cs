using AdoptionShelter.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.data;
using WebProject.data.models;

namespace AdoptionShelter.Adapters.DataAdapters
{
    public class PetDataAdapter : IPetAdapter
    {
        public List<Pet> GetListPets()
        {
            List<Pet> model = new List<Pet>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Pets.ToList();
            }
            return model;
        }
        public List<Shelter> GetListShelters()
        {
            List<Shelter> model = new List<Shelter>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Shelters.ToList();
            }
            return model;
        }

        public Pet GetPet(int id)
        {
            Pet pet = new Pet();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                pet = db.Pets.Include("Pets").Where(x => x.Id == id).FirstOrDefault();
            }
            return pet;
        }
        public void AddPet(Pet pet)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Pets.Add(pet);
                var sentback = db.SaveChanges();
            }
        }
        public void DeletePet(int Id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Pet pet = db.Pets.Find(Id);
                db.Pets.Remove(pet);
                db.SaveChanges();
            }
        }
        public void EditPet(Pet pet)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Pet model = db.Pets.Find(pet.Id);
                model.Name = pet.Name;
                model.Picture = pet.Picture;
                db.SaveChanges();
            }
        }
        public Pet GetPetByName(string pet)
        {
            Pet model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Pets.Include("Pets").Where(t => t.Name == pet).FirstOrDefault();
            };
            return model;
        }
        public void AdoptPet(int id)
        {
           using(ApplicationDbContext db = new ApplicationDbContext())
           {
               Pet pet = db.Pets.Find(id);
               db.Pets.Remove(pet);
               db.SaveChanges();
           }
        }
        public void AddShelter(Shelter shelter)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Shelters.Add(shelter);
                var sentback = db.SaveChanges();
            }
        }
        public void DeleteShelter(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Shelter shelter = db.Shelters.Find(id);
                db.Shelters.Remove(shelter);
                db.SaveChanges();
            }
        }
    }
}