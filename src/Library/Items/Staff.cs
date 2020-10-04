namespace RoleplayGame
{
    public class Staff : IItem
    {
        public int AttackValue 
        {
            get
            {
                return this.attackValue;
            } 
        }
        private int attackValue;

        private int defenseValue;

        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
        }
        public Staff(int attack, int defense)
        {
            this.attackValue = attack;
            this.defenseValue = defense;
        }
    }
}