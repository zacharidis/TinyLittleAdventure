//Tiny little adventure 
//By Georgios Zacharidis 

using TinyLittleAdventure.Source;
using TinyLittleAdventure.Source.Characters;
using TinyLittleAdventure.Source.Map;
using TinyLittleAdventure.Source.Text;


Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);



var playersName = Console.ReadLine();

if (playersName == String.Empty)
{
    playersName = Text.Language.DefaultName;
}

var player = new Player(playersName);


Console.WriteLine(Text.Language.Welcome , player.Name);

var house = new House(player);

