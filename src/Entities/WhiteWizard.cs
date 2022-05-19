using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_abstraindo_jogo_rpg.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int level){
            this.Name = Name;
            this.level = level;
            this.HeroType = "White Wizard";
            this.MaxHP = CalculateHP();
            this.CurrentHP = this.MaxHP;
            this.MaxMP = CalculateMP();
            this.CurrentMP = this.MaxMP;
        }

        public override string Attack()
        {
            return this.Name + " casts a white spell!";
        }

        public override int CalculateHP()
        {
            return this.level * 2;
        }

        public override int CalculateMP()
        {
            return this.level * 5;
        }
    }
}