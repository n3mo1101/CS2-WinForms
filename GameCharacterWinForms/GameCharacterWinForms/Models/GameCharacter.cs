using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterWinForms.Models
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        private int _Level { get; set; }
        private int _Health { get; set; }
        private int _Mana { get; set; }
        private int _Strength { get; set; }
        private int _Intelligence { get; set; }

        public int Level
        {
            get => _Level;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Level cannot be negative");
                _Level = value;
            }
        }

        public int Health
        {
            get => _Health;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Health cannot be negative");
                _Health = value;
            }
        }

        public int Mana
        {
            get => _Mana;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Mana cannot be negative");
                _Mana = value;
            }
        }

        public int Strength
        {
            get => _Strength;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Strength cannot be negative");
                _Strength = value;
            }
        }

        public int Intelligence
        {
            get => _Intelligence;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: Character Intelligence cannot be negative");
                _Intelligence = value;
            }
        }

        //public GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
        //{
        //    Name = name;
        //    Level = level;
        //    Health = health;
        //    Mana = mana;
        //    Strength = strength;
        //    Intelligence = intelligence;
        //}

        public abstract void Attack(out string message, out int finalDamage);
        public abstract string Defend();
        public abstract void LevelUp();
    }
}
