﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NodeCalculator.Models
{
    class ConstantNode : NodeBase
    {
        public ConstantNode()
        {
            Name = "Constant";

            PrevNodes = new NodeBase[0];
            NextNodes = new NodeBase[1];
        }

        public override void Do()
        {
            base.Do();


        }
    }
}
