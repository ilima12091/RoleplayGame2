namespace RoleplayGame
{
    public class Bow : IItem
    {
        public int AttackValue 
        {
            get
            {
                return this.attackValue;
            }
        }
        private int attackValue;
        public int DefenseValue
        {
            get
            {
                return 0;
            }
        }
        public Bow(int attack)
        {
            this.attackValue = attack;
        }
    }
}