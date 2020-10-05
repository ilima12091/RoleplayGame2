using System.Collections.Generic;

namespace RoleplayGame
{
    public class Dwarf : ICharacter
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
            this.Items = new List<Item>();
        }

        public string Name { get; set; }
        public List<Item> Items { get; }

        public int AttackValue {
            get
            {
                int itemsTotalAttack = 0;
                foreach(Item item in this.Items)
                {
                    itemsTotalAttack += item.AttackValue;
                }
                return itemsTotalAttack;
            }
        }
        public int DefenseValue {
            get
            {
                int itemsTotalDefense = 0;
                foreach(Item item in this.Items)
                {
                    itemsTotalDefense += item.DefenseValue;
                }
                return itemsTotalDefense;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(string name, int attackValue, int defenseValue)
        {
            Item item = new Item(name, attackValue, defenseValue);
            this.Items.Add(item);
        }

        public void RemoveItem(string name)
        {
            foreach(Item item in this.Items)
            {
                if(item.Name == name)
                {
                    this.Items.Remove(item);
                }
            }
        }
    }
}