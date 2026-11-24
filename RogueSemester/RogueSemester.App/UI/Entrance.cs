using System.Security.Cryptography.X509Certificates;

namespace RogueSemester.App.UI;


public class Entrance
{
public string GetName()
    {
        Console.WriteLine("Jak masz na imię?");
        
        string? name = Console.ReadLine();

        return name ?? "";
    }

}

