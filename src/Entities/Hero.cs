using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_abstraindo_jogo_rpg.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int level;
        public string HeroType;
        public int MaxHP;
        public int CurrentHP;
        public int MaxMP;
        public int CurrentMP;

        public Hero()
        {
            
        }

        public Hero(string Name, string HeroType, int level)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + "\nLevel: " + level + "\nClass: " + HeroType +"\nHP: "
                 + MaxHP + "/" + CurrentHP + "\nMP: " + MaxMP + "/" + CurrentMP;
        }

        public abstract string Attack();
        public abstract int CalculateHP();
        public abstract int CalculateMP();
    }

}