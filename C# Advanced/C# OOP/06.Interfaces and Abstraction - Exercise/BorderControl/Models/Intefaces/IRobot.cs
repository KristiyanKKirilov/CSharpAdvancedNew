﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models.Intefaces
{
    public interface IRobot:IIdentifiable
    {
        string Model { get; }
    }
}
