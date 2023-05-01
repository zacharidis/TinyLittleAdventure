using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLittleAdventure.Source.Characters
{
    // abstract one
    public abstract class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {

            Name = name;


        }



    }
}
