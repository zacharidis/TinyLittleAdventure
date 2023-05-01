using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyLittleAdventure.Source.Characters;

namespace TinyLittleAdventure.Source.Map
{
   public partial class House
    {
        
        public Player Player { get; } // can't set it 

        private readonly Random _rnd = new Random(1234); 


        
        public House(Player player) {
        
        
            Player = player;


        }


    }
}
