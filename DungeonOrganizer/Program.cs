// na razie nie wiem jak zrobic te dodatkowe foldery/programy. cos mi nie gra. ale wszystko dziala poza tym??
// zadania na jednym pliku because Im Scared

// DungeonOrganizer.Items.Item item = 
// new DungeonOrganizer.Items.Item("Mikstura", 15);
// DungeonOrganizer.Items.Weapon weapon = 
//    new DungeonOrganizer.Items.Weapon("Miecz", damage:40);

// zad 2 ^^^^^^^

using DungeonOrganizer.Characters;
using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem item = new InventoryItem("Mikstura", 15);
MapItem mapitem = new MapItem("MAPA", 15);
Weapon weapon = new Weapon("Miecz", damage:40);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);