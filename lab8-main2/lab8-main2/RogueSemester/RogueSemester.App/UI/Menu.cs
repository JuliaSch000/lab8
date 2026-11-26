namespace RogueSemester.App.UI;


public class Menu
{
public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("1. Rozpocznij następną walkę");
        Console.WriteLine("2. Pokaż stan bohatera");
        Console.WriteLine("3. Pokaż ekwipunek");
        Console.WriteLine("4. Zakończ wyprawę");
        Console.ResetColor();

        
        
    }


public string Choice()
    {
        string choice = Console.ReadLine();
        
        return choice;
    }
}

