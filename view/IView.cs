﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{

    interface IView
    {

        void DisplayWelcomeMessage();

        int GetInput();
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);

        bool NewGame(int input);
        bool Stand(int input);
        bool Hit(int input);
        bool Quit(int input);
    }
}
