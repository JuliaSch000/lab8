// zrobilam eksperymenty A i B w zad 4. nie rozumiem zbyt dobrze tej tabeli

//odp do zad 6:
// 1. Nie wydaje mi się
// 2. Pewnie dlatego, że importy znajdują się w folderach projektów i nie sięgają innych projektów
// 3. Ich jedyną zależnością zdaje się być to, że są używane w tym samym programie
// 4. globalny w całym projekcie, zwykły tylko w jednym pliku .cs
using System.Net.ServerSentEvents;



Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);
Item item1 = new Item("Mikstura", 15);
Item item2 = new Item("Miecz", 40);
Inventory inventory = new Inventory();

int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);
Console.WriteLine($"\n{item1.Name} - {item1.Price}");
Console.WriteLine($"{item2.Name} - {item2.Price}");
inventory.Add(item1);
inventory.Add(item2);
int total = inventory.CalculateValue();
Console.WriteLine($"Razem - {total}");
