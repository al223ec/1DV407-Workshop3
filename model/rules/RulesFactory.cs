using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    abstract class RulesFactory
    {
        public abstract IHitStrategy GetHitRule(); 

        public abstract INewGameStrategy GetNewGameRule(); 

        public abstract IOnDrawStrategy GetDrawRule();

        public void Accept(IRuleElementVisitor visitor)
        {
            GetHitRule().Accept(visitor);
            GetNewGameRule().Accept(visitor);
            GetDrawRule().Accept(visitor); 
        }
    }
}
