﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public interface IPizza
    {
        string getDescription();
        int getCost();
    }
}
