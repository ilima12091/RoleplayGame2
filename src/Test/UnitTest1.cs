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
            dwarf.Helmet = new Helmet(20);
            dwarf.Shield = new Shield(10);

            wizard = new Wizard("Jero");

            knight = new Knight("Rodri");
            knight.Sword = new Sword(10);

            knight2 = new Knight("Rodrialter");
            knight2.Sword = new Sword(50);
        }

        [Test]
        /*Este test prueba que si se realiza un ataque y 
        el atacado tiene más defensa que el ataque del atacante la vida se mantiene*/
        public void More_armor_than_attack()        
        {
            dwarf.ReceiveAttack(knight.AttackValue);
            Assert.True(dwarf.Health == 100);
        }
        [Test]
            /*Este test prueba que si un personaje es atacado y se le usa medotodo Revive 
             la salud del personaje se recupera a la inicial*/
         public void Revive()
         {
             dwarf.ReceiveAttack(knight2.AttackValue);
             dwarf.Cure();
             Assert.True(dwarf.Health == 100);
         }
          [Test]
          /*Este test prueba que el método ataque afecta correctamente a la vida del contrincante*/
          public void Attack()
          {
              dwarf.ReceiveAttack(knight2.AttackValue);
              Assert.True(dwarf.Health == 80);
          } 
    }

}