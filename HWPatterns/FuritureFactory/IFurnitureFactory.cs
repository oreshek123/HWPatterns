﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();

    }
}
