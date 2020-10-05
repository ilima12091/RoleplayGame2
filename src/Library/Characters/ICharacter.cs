using System.Collections.Generic;

namespace RoleplayGame
{
    /* Interfaz que sirve de molde para todo personaje del tipo ICharacter con todas las cosas que tienen en común */
    public interface ICharacter
    {
        int Health { get; set; }
        string Name { get; set; }
        int AttackValue { get; }
        int DefenseValue { get; }
        List<Item> Items { get; }
        void ReceiveAttack(int power);
        void Cure();
        void AddItem(string name, int attackValue, int defenseValue);
        void RemoveItem(string name);
    }
}