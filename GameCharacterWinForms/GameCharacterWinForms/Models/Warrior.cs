using GameCharacterWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameCharacterWinForms.Models
{
    internal class Warrior : GameCharacter
    {
        public int Armor { get; set; }
        public int Stamina { get; set; }



        //public Warrior(string name, int level, int health, int strength)
        //    : base(name, level, health, 0, strength, 0)
        //{

        //}

        public override void Attack(out string message, out int finalDamage)
        {
            int baseDamage = Strength * 2;
            int criticalRate = new Random().Next(0, 99);
            bool criticalHit = criticalRate < 20 ? true : false;
            finalDamage = criticalHit ? baseDamage * 2 : baseDamage;

            if (criticalHit)
                message = $"Attack: {Name} attacks and deals {finalDamage} damage. It was a critical hit!";
            else
                message = $"Attack: {Name} attacks and deals {finalDamage} damage.";
        }

        public override string Defend()
        {
            int damageReduction = Armor / 2;
            int blockRate = new Random().Next(0, 99);
            bool blockedDamage = blockRate < 15 ? true : false;

            if (blockedDamage)
                return $"Defend: {Name} blocked the incoming attack! All damage is negated.";
            else
                return $"Defend: {Name} guards for the incoming attack. Damage received is reduced by {damageReduction}.";
        }

        public override void LevelUp()
        {
            const int STR = 5, HP = 20, SP = 15, DF = 2;

            Level++;
            Strength += STR;
            Health += HP;
            Stamina += SP;
            Armor += DF;

            Console.WriteLine($"{Name} has reached Level {Level}!");
            Console.WriteLine($"Stats Increased: Strength +{STR}, Health +{HP}, Stamina +{SP}, Armor +{DF}");
        }

        public override string ToString()
        {
            return $"Name: {Name}\r\n" +
            $"Class: Warrior\r\n" +
            $"\r\nLevel: {Level}\r\n" +
            $"Health: {Health} / {Health}\r\n" +
            $"Stamina: {Stamina} / {Stamina}\r\n" +
            $"Strength: {Strength}\r\n" +
            $"Armor: {Armor}";
        }
    }
}
