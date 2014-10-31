using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IRuleElement
    {
        void Accept(IRuleElementVisitor visitor); 
    }
}
