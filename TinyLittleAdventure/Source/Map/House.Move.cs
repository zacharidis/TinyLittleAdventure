namespace TinyLittleAdventure; 

public partial class House
{
    public Room CurrentRoom { get; set; }   


    public void GoToRoom(int index)
    {

        if (CurrentRoom != null)
        {
            CurrentRoom.isVisited = true;
            CurrentRoom = Rooms[index];
        }

    }

    public void GoToStartingRoom()
    
    { 
        
        GoToRoom(_rnd.Next(0, Rooms.Length));
    }


}