using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTest
    {

        private Dwarf dwarf;
        private Knight knight;
        private Knight knight2;
        private Wizard wizard;

        [SetUp]
        public void Setup()
        {
            dwarf = new Dwarf("Nacho");
            dwarf.AddItem("Helmet", 0, 20);
            dwarf.AddItem("Shield", 0, 10);

            wizard = new Wizard("Jero");
            SpellsBook book = new SpellsBook();
            book.AddSpell("Bola de fuego", 10, 0);
            book.AddSpell("Escudo de maná", 0, 20);
            wizard.SpellsBook = book;

            knight = new Knight("Rodri");
            knight.AddItem("Sword", 10, 0);

            knight2 = new Knight("Rodrialter");
            knight2.AddItem("Sword", 50, 0);
        }

        [Test]
        /*
            Este test prueba que si se realiza un ataque y 
            el atacado tiene más defensa que el ataque del atacante la vida se mantiene
        */
        public void More_armor_than_attack()        
        {
            dwarf.ReceiveAttack(knight.AttackValue);
            Assert.True(dwarf.Health == 100);
        }
        [Test]
        /*
            Este test prueba que si un personaje es atacado y se le usa medotodo Revive 
            la salud del personaje se recupera a la inicial
        */
        public void Revive()
        {
            dwarf.ReceiveAttack(knight2.AttackValue);
            dwarf.Cure();
            Assert.True(dwarf.Health == 100);
        }
        [Test]
        /*
            Este test prueba que el método ataque afecta correctamente a la vida del contrincante
        */
        public void Attack()
        {
            dwarf.ReceiveAttack(knight2.AttackValue);
            Assert.True(dwarf.Health == 80);
        } 
    }

}