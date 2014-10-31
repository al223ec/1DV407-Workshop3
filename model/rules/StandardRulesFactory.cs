using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class StandardRulesFactory : RulesFactory
    {
        public override IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public override INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public override IOnDrawStrategy GetDrawRule()
        {
            return new DealerWinsOnDrawStrategy();
        }
    }
}
