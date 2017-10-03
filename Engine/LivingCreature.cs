﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //To serve as base class for monsters/players
    public class LivingCreature
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }

    }



}
