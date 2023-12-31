﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Heros
{    
    public class Druid : BaseHero
    {
        private const int DruidPower = 80;
        public Druid(string name)
            : base(name, DruidPower)
        {
        }
        public override int Power => DruidPower;
        public override string CastAbility()
            => $"{this.GetType().Name} - {Name} healed for {Power}";
    }
}
