using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLittleAdventure.Source.Text
{
    public class English : Language
    {

        public English() {

            ChooseYourName = "Hello , what is your name ?";
            DefaultName = "No Name Adventurer";
            Welcome = "Welcome {0} to your Tiny Little Adventure";
        

        }

    }
}
