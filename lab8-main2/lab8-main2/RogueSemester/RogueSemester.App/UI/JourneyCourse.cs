namespace RogueSemester.App.UI;

public class JourneyCourse
{

   
    public void Execute(string choice, Player player)
    {

        
        switch (choice)
        {
            case "1":
                {
                    Console.WriteLine($"Rozpoczynasz walkę!");
                    Console.WriteLine($"{player.Name}");
                    break;
                }
                default:
                {
                    break;
                }
        }
    }


}