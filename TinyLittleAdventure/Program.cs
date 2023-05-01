//Tiny little adventure 
//By Georgios Zacharidis 

using TinyLittleAdventure.Source; 

Console.WriteLine("Hello there , are you ready for an adventure ?");
Console.WriteLine("Enter your name and hit enter");

var playersName = Console.ReadLine();

if (playersName == String.Empty)
{
    playersName = "No Name";
}

var player = new Player(playersName);


Console.WriteLine($"Welcome {player.Name}");

