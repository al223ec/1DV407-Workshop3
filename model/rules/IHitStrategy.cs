using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IHitStrategy : IRuleElement
    {
        bool DoHit(model.Player a_dealer);
    }
}
