namespace pa5dwelchel

{
    public interface IAttack
    {
        void Attack(Character opponent);
        void Defend(Character defender, int incomingAtk);
    }
}