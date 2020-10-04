namespace RoleplayGame
{
    public class Helmet : IItem
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
        public Helmet(int defense)
        {
            this.defenseValue = defense;
        }
    }
}