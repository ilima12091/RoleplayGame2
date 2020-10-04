namespace RoleplayGame
{
    public class Axe : IItem
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
        public Axe(int attack)
        {
            this.attackValue = attack;
        }
    }
}