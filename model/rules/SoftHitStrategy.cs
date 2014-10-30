using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class SoftHitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            var gotAce = a_dealer.GetHand().FirstOrDefault(c => c.GetValue() == BlackJack.model.Card.Value.Ace);
            return ((a_dealer.CalcScore() < g_hitLimit) || a_dealer.CalcScore() == g_hitLimit && gotAce != null);
        }
        public void Accept(IRuleElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
