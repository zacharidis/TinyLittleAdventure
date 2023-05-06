using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyLittleAdventure.Source;
using TinyLittleAdventure.Source.Map;
using TinyLittleAdventure.Source.Text;

namespace TinyLittleAdventure
{
    public class Room
    {

        public string Name { get; set; } = Text.Language.DefaultRoomName;
        public string Description { get; set; } = Text.Language.DefaultRoomDescription;

        public Dictionary<Directions, int> Neighbours { get; set; } = new()
        {

            { Directions.North, -1
            },
            { Directions.South, -1
            },
            { Directions.East, -1
            },

            { Directions.West, -1
            },
            { Directions.None, -1
            },




        };
        

        public bool isVisited { get; set; }  
    }
}
