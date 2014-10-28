using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinsOnDrawStrategy : IOnDrawStrategy
    {
        public bool DealerWins()
        {
            return false;
        }
    }
}
