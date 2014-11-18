using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : BaseView, IView
    {
        protected override char hit
        {
            get
            {
                return 'h';
            }
        }
        protected override char stand
        {
            get
            {
                return 's'; 
            }

        }
        protected override char play
        {
            get
            {
                return 'p';
            }
        }
        protected override char quit
        {
            get
            {
                return 'q';
            }
        }


        public override void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.WriteLine("Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n");
        }


        public override void DisplayCard(model.Card a_card)
        {
            var value = a_card.GetValue();
            var color = a_card.GetColor(); 

            System.Console.WriteLine("{0} of {1}", value, color);
        }

        public override void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public override void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public override void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }
            
        }
    }
}
