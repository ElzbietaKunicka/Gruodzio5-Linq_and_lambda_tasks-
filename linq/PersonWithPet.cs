using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class PersonWithPet
    {
        //Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė,
        //gyvūnai turi tik vardą). Sukurkite sąrašą su Person objektais ir
        //viduje esančiais gyvūnų sąrašais.

        public string Name { get; set; }

        public List<Pet> Animals { get; set; }


        public PersonWithPet(string name, List<Pet> animal)
        {
            Name = name;
            Animals = animal;
        }
    }
}
