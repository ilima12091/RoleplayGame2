using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell("Bola de fuego", 10, 0);
            book.AddSpell("Escudo de maná", 0, 20);

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.SpellsBook = book;
            gandalf.AddItem("Staff", 30, 20);

            Dwarf gimli = new Dwarf("Gimli");
            gimli.AddItem("Helmet", 0, 20);
            gimli.AddItem("Axe", 40, 0);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
