Console.WriteLine("Hello there , are you ready for an adventure ?");
Console.WriteLine("Enter your name and hit enter");

var playersName = Console.ReadLine();

if (playersName == String.Empty)
{
    playersName = "No Name";
}

Console.WriteLine($"Welcome {playersName}");

