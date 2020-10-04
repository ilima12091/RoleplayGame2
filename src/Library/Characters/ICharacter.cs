using System.Collections.Generic;

namespace RoleplayGame
{
    public interface ICharacter
    {
        int Health { get; set; }
        string Name { get; set; }
        int AttackValue { get; }
        int DefenseValue { get; }
        List<IItem> Items { get; };
        void ReceiveAttack(int power);
        void Cure();
    }
}