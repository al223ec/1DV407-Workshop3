using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class DealerWinsOnDrawStrategy : IOnDrawStrategy
    {
        public bool DealerWins()
        {
            return true;
        }
        public void Accept(IRuleElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
