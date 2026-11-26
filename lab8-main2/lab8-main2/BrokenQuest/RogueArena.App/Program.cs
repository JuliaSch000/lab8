// nie moge zapisac bledu bo to naprawilam zanim przeszlam do zadania 7  lol
// ale pojawily sie dwie literowki ( w RogueArena.Core.Reward(s) ),
// brakowalo "public" w public class. I wszystkie zaleznosci dzialaja jak powinny teraz


using System.Net.ServerSentEvents;



Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Kosmita", 25);
Companion companion = new Companion("Borys");

int reward = RewardCalculator.Calculate(45);

Console.WriteLine($"=====================");
Console.WriteLine(PartyReport.Create(hero, companion));
Console.WriteLine($"{hero.Name} i {companion.Name} pokonują: {monster.Name}");
Console.WriteLine($"Nagroda: {reward} szt. złota");
Console.WriteLine(BattleReport.Create(hero, monster, reward));
Console.WriteLine($"=====================");