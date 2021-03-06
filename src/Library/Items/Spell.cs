namespace RoleplayGame
{
    public class Spell : IItem
    {
        public string Name { get; }

        public int AttackValue { get; }

        public int DefenseValue { get; }
        
        public Spell(string name, int attack, int defense)
        {
            this.Name = name;
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }
    }
}