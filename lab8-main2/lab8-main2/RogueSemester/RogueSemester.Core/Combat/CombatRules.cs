using RogueSemester.Core.Characters;

namespace RogueSemester.Core.Combat;

public class CombatRules
{
    public Player Player{get;set;}
    public void Fight()
    {
        Player.TakeDamage(); // khdfgkjsbgljsbgt
    }
}