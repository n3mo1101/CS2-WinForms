using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameCharacterWinForms.Models
{
    internal class Mage : GameCharacter
    {
        public int SpellPower { get; set; }

        //public Mage(string name, int level, int health, int mana, int intelligence)
        //    : base(name, level, health, mana, 0, intelligence)
        //{

        //}

        public override void Attack(out string message, out int magicDamage)
        {
            magicDamage = (Intelligence * 3) + SpellPower;
            int burnChance = new Random().Next(0, 99);
            bool burnEffect = burnChance < 25 ? true : false;

            if (burnEffect)
                message = $"Attack: {Name} casts a spell and deals {magicDamage} magic damage. Additional burn effect is applied.";
            else
                message = ($"Attack: {Name} casts a spell and deals {magicDamage} magic damage.");
        }

        public override string Defend()
        {
            int damageReduction = Mana / 4;
            int evadeChance = new Random().Next(0, 99);
            bool evadeAttack = evadeChance < 20 ? true : false;

            if (evadeAttack)
                return $"Defend: {Name} evades the attack and negates all incoming damage.";
            else
                return $"Defend: {Name} guards for the incoming attack. Damage received is reduced by {damageReduction}.";
        }

        public override void LevelUp()
        {
            const int INT = 5, HP = 15, MP = 20, SP = 2;

            Level++;
            Health += HP;
            Intelligence += INT;
            Mana += MP;
            SpellPower += SP;

            Console.WriteLine($"{Name} has reached Level {Level}!");
            Console.WriteLine($"Stats Increased: Health +{HP}, Mana +{MP}, Intelligence +{INT}, Spell Power +{SP}");
        }

        public override string ToString()
        {
            return $"Name: {Name}\r\n" +
            $"Class: Mage\r\n" +
            $"\r\nLevel: {Level}\r\n" +
            $"Health: {Health} / {Health}\r\n" +
            $"Mana: {Mana} / {Mana}\r\n" +
            $"Intelligence: {Intelligence}\r\n" +
            $"Spell Power: {SpellPower}";
        }
    }
}
