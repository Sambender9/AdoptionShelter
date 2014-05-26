using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using WebProject.data.models;

namespace WebProject.data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, bool createCat = true, bool createDog = true, bool createLizard = true, bool createPig = true, bool createShelter = true)
        {
            if (createShelter)
            { 
                CreateShelter(context);
            }
            if (createCat)
            {
                CreateCat(context);
            }
            if (createDog)
            {
                CreateDog(context);
            }
            if (createLizard)
            {
                CreateLizard(context);
            }
            if (createPig)
            {
                CreatePig(context);
            } 
        }
        private static void CreateCat (ApplicationDbContext context)
        {
            //seed the db with Cats
            context.Cats.AddOrUpdate(c => c.Name,
                new Cat { Name = "Mittens",  Picture = "http://exocticpetplus.com/wp-content/uploads/2014/01/Persian-Kittens.jpg", Age = 1, Breed = "Persian", ShelterId = 1 },
                new Cat { Name = "Socks",    Picture = "http://static-2.nexusmods.com/15/mods/140/images/910-2-1269342772.jpg", Age = 4, Breed = "Siamese", ShelterId = 2 },
                new Cat { Name = "Fluffy",   Picture = "http://1.bp.blogspot.com/_y9hRNmeik1w/TLCUocr00DI/AAAAAAAAAbo/e1rdKcTto3U/s1600/siamese+cat+picture.JPG", Age = 7, Breed = "Siamese", ShelterId = 2 },
                new Cat { Name = "Snowball", Picture = "http://jmacg.files.wordpress.com/2009/05/burmese-month-old-kitten.jpg", Age = 20, Breed = "Burmese", ShelterId = 2 }
        );
        context.SaveChanges();
        }
        private static void CreateDog (ApplicationDbContext context)
        {
            //seed the db with Dogs
            context.Dogs.AddOrUpdate(d => d.Name,
                new Dog { Name = "Clifford", Picture = "http://whiteoakgoldenretrievers.com/images/boygirlpics%20001.jpg", Age = 7, Breed = "Golden Retriever", ShelterId = 2 },
                new Dog { Name = "Madison",  Picture = "https://scontent-a-iad.xx.fbcdn.net/hphotos-ash3/t1.0-9/71620_592631270462_5049628_n.jpg", Age = 3, Breed = "Pitbull", ShelterId = 2 },
                new Dog { Name = "Sparky",   Picture = "http://www.animal-images.com/data/photos/29_1shitzu_portrait_kentucky_dog.jpg", Age = 1, Breed = "Shitzu", ShelterId = 2 },
                new Dog { Name = "Boots",    Picture = "http://dog-breeds-spot.com/wp-content/uploads/2009/02/dalmatian.jpg", Age = 2, Breed = "Dalmatian", ShelterId = 2 }
                );
            context.SaveChanges();
        }
        private static void CreateLizard(ApplicationDbContext context)
        {
            //seed the db with Lizards
            context.Lizards.AddOrUpdate(z => z.Name,
                new Lizard { Name = "Lizzy",   Picture = "http://4.bp.blogspot.com/-hFTYQQEFV1s/UD3SAUbZATI/AAAAAAAAPOs/3IjVrZHswHk/s1600/Chameleon4.jpg", Age = 7, Breed = "Chameleon", ShelterId = 2 },
                new Lizard { Name = "Zach",    Picture = "http://www.crestedgecko.com/uploads/images/amel08-002m.JPG", Age = 6, Breed = "Crested Gecko", ShelterId = 2 },
                new Lizard { Name = "Lionel",  Picture = "http://1.bp.blogspot.com/-kd8BwcukBm4/UETHcfArP3I/AAAAAAAAAtg/C0akpnJh2sA/s1600/cheats-chameleon.jpg", Age = 5, Breed = "Chameleon", ShelterId = 2 },
                new Lizard { Name = "Liza",    Picture = "http://upload.wikimedia.org/wikipedia/commons/4/4b/Green_anole.jpg", Age = 2, Breed = "Green Anole", ShelterId = 2 }
                );
            context.SaveChanges();
        }
        private static void CreatePig(ApplicationDbContext context)
        {
            //seed the db with Pigs
            context.Pigs.AddOrUpdate(p => p.Name,
                new Pig { Name = "Bacon",       Picture = "http://media.npr.org/assets/img/2013/08/02/mangalitsa-1e6ed8924e45ae530628a63c67e535f843c2d3f4-s6-c30.jpg", Age = 11, Breed = "Magalitsa", ShelterId = 2 },
                new Pig { Name = "Daisey-Anne", Picture = "http://upload.wikimedia.org/wikipedia/commons/8/84/Sus_scrofa_domestica.jpg", Age = 3, Breed = "Pot-Bellied pig", ShelterId = 2 },
                new Pig { Name = "Krista-Anne", Picture = "http://www.ansi.okstate.edu/breeds/swine/duroc/duroc.jpg", Age = 18, Breed = "Duroc", ShelterId = 2 },
                new Pig { Name = "Sarah-Anne",  Picture = "http://heirloomrestaurantgroup.com/blog/wp-content/uploads/2011/01/m_1022080c.jpg", Age = 9, Breed = "Bershire", ShelterId = 2 }
                );
            context.SaveChanges();
        }
        private static void CreateShelter(ApplicationDbContext context)
        {
            //seed the db with animal shelters
            context.Shelters.AddOrUpdate(s => s.Name,
                new Shelter { Name = "New Best Friends Animal Shelter", Address = "125 Adopt Me Lane Houston, TX 28220", ShelterPic = "http://media.masslive.com/breakingnews/photo/2011/08/9875830-large.jpg" },
                new Shelter { Name = "Tri-City Animal Adoption",        Address = "3356 New Beginnings Drive Pearland, TX 28148", ShelterPic = "http://i45.photobucket.com/albums/f79/fixyourdogorcat/AnimalShelter.jpg" }
                );
            context.SaveChanges();
        }
    }
}
 