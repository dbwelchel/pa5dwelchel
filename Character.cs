
namespace pa5dwelchel

{
     public class Character
{
    public string Name { get; set; }
    public int MaxPower { get; }
    public int Health { get; set; }
    public int AtkPwr { get; set; }
    public int DefPwr { get; set; }
    public IAttack AttackType { get; }

    public Character(string name, IAttack attackType)
    {
        Name = name;
        MaxPower = new Random().Next(1, 101);
        Health = 100;
        AtkPwr = new Random().Next(1, MaxPower + 1);
        DefPwr = new Random().Next(1, MaxPower + 1);
        AttackType = attackType;
    }

    public void Attack(Character opponent)
    {
        AttackType.Attack(opponent);
        UpdateStats();
    }

    public void Defend(int incomingAtk)
    {
        AttackType.Defend(this, incomingAtk);
        UpdateStats();
    }
    private void UpdateStats()
    {
        AtkPwr = new Random().Next(1, MaxPower + 1);
        DefPwr = new Random().Next(1, MaxPower + 1);
    }

    public void DisplayStats()
    {
        
        Console.WriteLine($"{Name}'s Stats:");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine();
    }
}
    }
