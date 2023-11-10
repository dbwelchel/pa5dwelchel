namespace pa5dwelchel

{
     public class Punch : IAttack
{
    public void Attack(Character opponent)
    {
        double typeBonus = GetTypeBonus(opponent);

        // Calculate damage dealt
        int damageDealt = Math.Max(0, (int)((opponent.AtkPwr - opponent.DefPwr) * typeBonus));

        // Apply damage
        opponent.Health = Math.Max(0, opponent.Health - damageDealt);
        Console.Clear();
        Console.WriteLine($"{opponent.Name} is attacked with Punch!");
        Console.WriteLine($"Power: {opponent.AtkPwr}, Defense: {opponent.DefPwr} Damage Dealt: {damageDealt}, Type Bonus: {typeBonus}");
    }

    public void Defend(Character defender, int incomingPower)
    {
        
          int damageBlocked = Math.Max(0, incomingPower - defender.DefPwr);
        defender.Health = Math.Max(0, defender.Health - damageBlocked);
        Console.WriteLine($"{defender.Name} is defending with Punch!");
        Console.WriteLine($"Defensive Power: {defender.DefPwr}, Damage Blocked: {damageBlocked}");
    }

    private double GetTypeBonus(Character opponent)
    {
        double typeBonus = 1.0;

        // Checks typing
        if (opponent is Mario)
        {
            typeBonus = 1.2;
        }

        return typeBonus;
    }
}
    }
    
