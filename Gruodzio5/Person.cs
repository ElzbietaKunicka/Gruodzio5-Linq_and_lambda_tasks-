using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruodzio5
{
    public class Person
    { // Sukurkite klasę Person su string name ir int age
      //Main metode sukurkite sąrašą žmonių skirtingais vardais ir amžiaus
      //Sukurkite delegatą Filter, kuris grąžins bool o per parametrą pasiims Person objektą.
      //Sukurkite tris metodus kurie grąžins bool reikšmes ir priiminės
      //Person per parametrą, vienas metodas tikrins ar žmogus yra vaikas < 18 metų,
      //kitas tikrins ar suaugęs >= 18 metų ir trečias tikrins ar senjoras >= 65 metai.
      //Sukurkite metodą DisplayPeople, su parametrais title, List<Person> ir delegatu Filter.
      //Metodo esmė bus eiti ciklu per asmenys ir paleisdinėti perduotą per parametrus filtrą patikrinti
      //ar žmogus pvz. yra vaikas.

        //Metodo kvietimas atrodys maždaug taip: DisplayPeople("Children:", people, IsChild);

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
