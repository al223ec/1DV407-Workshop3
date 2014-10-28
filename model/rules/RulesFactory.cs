﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            //return new BasicHitStrategy();
            return new SoftHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public IOnDrawStrategy GetDrawRule()
        {
            return new PlayerWinsOnDrawStrategy();
            //return new DealerWinsOnDrawStrategy();
        }

    }
}
