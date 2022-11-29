using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_250_Activity4
{
    public class SuperHeroList
    {
        public List<SuperHero> listOfHeroes { get; set; }

        public SuperHeroList()
        {
            listOfHeroes = new List<SuperHero>();
        }
    }
}
