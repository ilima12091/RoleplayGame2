namespace RoleplayGame
{
    public class Sword : IItem
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
        public Sword (int attack)
        {
            this.attackValue = attack;
        }
    }

}