using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IRuleElementVisitor
    {
        void Visit(IHitStrategy hitStrategy);

        void Visit(INewGameStrategy newGameStrategy);

        void Visit(IOnDrawStrategy onDrawStrategy);
    }
}
