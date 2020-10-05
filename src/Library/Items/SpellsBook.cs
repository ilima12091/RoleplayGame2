using System.Collections.Generic;

namespace RoleplayGame
{
    /*
        Esta clase se encarga de llevar una lista de hechizos y agregarlos al Spellbook, en el método AddSpell se aplica el patrón Creator
        y el principio Expert porque Spellbook utiliza una lista de Spells lo que la vuelve una experta en crear hechizos.
    */ 
    public class SpellsBook : IItem
    {
        public List<Spell> Spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }

        public void AddSpell(string name, int attack, int defense) 
        {
            Spell spell = new Spell(name, attack, defense);
            this.Spells.Add(spell);
        }

        public SpellsBook()
        {
            this.Spells = new List<Spell>();
        }
    }
}