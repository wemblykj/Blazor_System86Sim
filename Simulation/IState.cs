﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public interface IState
    {
        bool HasChanged { get; }
    }
}
