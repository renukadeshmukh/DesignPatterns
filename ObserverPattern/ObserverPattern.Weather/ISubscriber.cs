﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public interface ISubscriber
    {
        void Update(int temp, int humidity, int preassure);
    }
}
