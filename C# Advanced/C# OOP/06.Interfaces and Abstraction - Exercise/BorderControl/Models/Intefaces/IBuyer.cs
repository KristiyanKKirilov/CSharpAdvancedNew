﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models.Intefaces
{
    public interface IBuyer:INameable
    {
        int Food { get; }
        void BuyFood();

    }
}
