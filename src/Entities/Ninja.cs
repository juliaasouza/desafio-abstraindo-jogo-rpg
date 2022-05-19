using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_abstraindo_jogo_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int level){
            this.Name = Name;
            this.level = level;
            this.HeroType = "Ninja";
            this.MaxHP = CalculateHP();
            this.CurrentHP = this.MaxHP;
            this.MaxMP = CalculateMP();
            this.CurrentMP = this.MaxMP;
        }

        public override string Attack()
        {
            return this.Name + " attacks with their katana!";
        }

        public override int CalculateHP()
        {
            return this.level * 4;
        }

        public override int CalculateMP()
        {
            return this.level * 3;
        }
    }
}