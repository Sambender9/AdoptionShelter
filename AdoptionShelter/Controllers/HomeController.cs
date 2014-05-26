using AdoptionShelter.Adapters.DataAdapters;
using AdoptionShelter.Adapters.Interfaces;
using AdoptionShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.data;
using WebProject.data.models;

namespace AdoptionShelter.Controllers
{
    public class HomeController : Controller
    {
        private IPetAdapter _adapter;

        public HomeController(IPetAdapter adapter)
        { 
           _adapter = adapter;
            
        }
        public HomeController() 
        {
            _adapter = new PetDataAdapter();
        }
        public ActionResult Index()
        {
            List<Pet> pets = _adapter.GetListPets();
            return View(pets);
        }
        public ActionResult Pets()//Just use the homepage instead???
        {
            var model = _adapter.GetListPets();
            return View(model);
        }
        public ActionResult Shelter()
        {
            var model = _adapter.GetListShelters();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddPet()
        {
            AddEditVM model = new AddEditVM();
            model.Title = "Add your pet for adoption";
            model.ButtonMessage = "Add";
            return View(model);
        }
        [HttpPost]
        public ActionResult AddPet(Pet pet)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Pets.Add(pet);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditPet(int id)
        {
            AddEditVM model = new AddEditVM();
            model.Pet = _adapter.GetPet(id);
            model.Title = "Edit Pet" + model.Pet.Name;
            model.ButtonMessage = "Submit Changes";
            return View("AddPet", model);
        }
        [HttpPost]
        public ActionResult EditPet(Pet pet)
        {
            _adapter.EditPet(pet);

            return RedirectToAction("Pet", new { id = pet.Id });
        }
        [HttpGet]
        public ActionResult AdoptPet(int Id)
        {
            _adapter.AdoptPet(Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddShelter()
        {
            AddEditVM model = new AddEditVM();
            model.Title = "Add your Shelter!";
            model.ButtonMessage = "Add";
            return View(model);
        }
        [HttpPost]
        public ActionResult AddShelter(Shelter shelter)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Shelters.Add(shelter);
                db.SaveChanges();
            }
            return RedirectToAction("Shelter");
        }
        [HttpGet]
        public ActionResult DeleteShelter(int Id)
        {
            _adapter.DeleteShelter(Id);
            return RedirectToAction("Shelter");
        }
        public ActionResult PetDetails()
        {
            return View();
        }
        public ActionResult ShelterDetails()
        {
            return View();
        }
    }
}