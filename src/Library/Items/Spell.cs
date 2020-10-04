namespace RoleplayGame
{
    public class Spell : IItem
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
        public Spell(int attack, int defense)
        {
            this.attackValue = attack;
            this.defenseValue = defense;
        }
    }
}