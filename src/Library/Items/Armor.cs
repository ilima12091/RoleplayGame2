namespace RoleplayGame
{
    public class Armor : IItem
    {
        private int defenseValue;
        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
        }

        public int AttackValue
        {
            get
            {
                return 0;
            }
        }

        public Armor(int value)
        {
            this.defenseValue = value;
        }
    }
}