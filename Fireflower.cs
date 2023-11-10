namespace pa5dwelchel

{
  public class Fireflower : IAttack
{
    public void Attack(Character opponent)
    {
        double typeBonus = GetTypeBonus(opponent);

        // Calculate damage dealt
        int damageDealt = Math.Max(0, (int)((opponent.AtkPwr - opponent.DefPwr) * typeBonus));

        // Apply damage 
        opponent.Health = Math.Max(0, opponent.Health - damageDealt);
        Console.Clear();
        Console.WriteLine($"{opponent.Name} is attacked with Fireflower!");
        Console.WriteLine($"Power: {opponent.AtkPwr}, Defense: {opponent.DefPwr} Damage Dealt: {damageDealt}, Type Bonus: {typeBonus}");
    }

     public void Defend(Character defender, int incomingAtk)
    {
        
          int damageBlocked = Math.Max(0, incomingAtk - defender.DefPwr);
        defender.Health = Math.Max(0, defender.Health - damageBlocked);
        Console.WriteLine($"{defender.Name} is defending with Fireflower!");
        Console.WriteLine($"Defensive Power: {defender.DefPwr}, Damage Blocked: {damageBlocked}");
    }

    private double GetTypeBonus(Character opponent)
    {
        double typeBonus = 1.0;

        // Check typing
        if (opponent is Bowser)
        {
            typeBonus = 1.2;
        }

        return typeBonus;
    }
}

}
