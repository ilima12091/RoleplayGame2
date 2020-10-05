namespace RoleplayGame
{   
    public class Item : IItem
    {
        public string Name { get; }
        public int AttackValue { get; }
        public int DefenseValue { get; }
    
        public Item(string name, int attackValue, int defenseValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}