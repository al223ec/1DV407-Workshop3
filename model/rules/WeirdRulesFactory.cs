using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class WeirdRulesFactory : RulesFactory
    {
        public override IHitStrategy GetHitRule()
        {
            return new SoftHitStrategy(); 
        }

        public override INewGameStrategy GetNewGameRule()
        {
            return new InternationalNewGameStrategy(); 
        }

        public override IOnDrawStrategy GetDrawRule()
        {
            return new PlayerWinsOnDrawStrategy(); 
        }
    }
}
