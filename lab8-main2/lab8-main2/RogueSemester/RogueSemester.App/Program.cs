using System.Net.ServerSentEvents;

Entrance entrance = new Entrance();
string name = entrance.GetName();
Menu menu = new Menu();
JourneyCourse journeyCourse = new JourneyCourse();


bool gameOn = true;
Player player = new Player(name, 30);
Item item = new Item("Mikstura", 15);

while (gameOn)
{
    CombatRules combatRules = new CombatRules();
    combatRules.Player = player;
    menu.Show();
    string choice = menu.Choice();
    journeyCourse.Execute(choice, player);
    switch (choice)
    {
        case "1":
                {
                   
                    break;
                }
                default:
                {
                    break;
                }
    }
}

