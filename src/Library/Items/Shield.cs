namespace RoleplayGame
{
    public class Shield : IItem
    {
        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
        }
        private int defenseValue;
        public int AttackValue
        {
            get
            {
                return 0;
            }
        }
        public Shield(int defense)
        {
            this.defenseValue = defense;
        }
    }
}