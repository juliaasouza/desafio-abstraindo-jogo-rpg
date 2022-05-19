using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_abstraindo_jogo_rpg.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int level){
            this.Name = Name;
            this.level = level;
            this.HeroType = "Black Wizard";
            this.MaxHP = CalculateHP();
            this.CurrentHP = this.MaxHP;
            this.MaxMP = CalculateMP();
            this.CurrentMP = this.MaxMP;
        }

        public override string Attack()
        {
            return this.Name + " casts a black spell!";
        }

        public override int CalculateHP()
        {
            return this.level * 3;
        }

        public override int CalculateMP()
        {
            return this.level * 4;
        }
    }
}