//Tiny little adventure 
//By Georgios Zacharidis 

using TinyLittleAdventure.Source;
using TinyLittleAdventure.Source.Characters;
using TinyLittleAdventure.Source.Text;

var language = new English();



var playersName = Console.ReadLine();

if (playersName == String.Empty)
{
    playersName = "No Name";
}

var player = new Player(playersName);


Console.WriteLine($"Welcome {player.Name}");

