using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace home01.Models
{
    public class ListOfPets
    {
        public static IEnumerable<Pet> createPets()
        {
            List<Pet> pets = new List<Pet>();

            pets.Add(new Pet()
            {
                name = "Юкар",
                img_path = "../../Images/dog.JPG",
                info = "Чау-чау"
            });

            pets.Add(new Pet()
            {
                name = "Ириска",
                img_path = "../../Images/cat.JPG",
                info = "Просто кошка"
            });

            return pets;
        }
    }
}