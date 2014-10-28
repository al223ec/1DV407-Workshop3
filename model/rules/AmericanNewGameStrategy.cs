using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            a_player.DealCard(a_deck, show: true);
            a_dealer.DealCard(a_deck, show: true);
            a_player.DealCard(a_deck, show: true);
            a_dealer.DealCard(a_deck, show: false); 

            return true;
        }
    }
}
