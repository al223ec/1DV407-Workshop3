using BlackJack.model.rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    abstract class BaseView  : IView
    {
        protected abstract char hit
        {
            get;
        }
        protected abstract char stand
        {
            get;
        }
        protected abstract char play
        {
            get;
        }
        protected abstract char quit
        {
            get;
        }

        public int GetInput()
        {
            return System.Console.Read(); 
        }

        public void Clear()
        {
            Console.Clear(); 
        }

        public void ContinueOnEnter()
        {
            Console.ReadLine(); 
        }


        public bool NewGame(int input)
        {
            return play == input;
        }
        public bool Stand(int input)
        {
            return stand == input;
        }
        public bool Hit(int input)
        {
            return hit == input;
        }
        public bool Quit(int input)
        {
            return quit == input;
        }


        public void Visit(IHitStrategy hitStrategy)
        {
            Console.WriteLine(hitStrategy); 
        }

        public void Visit(INewGameStrategy newGameStrategy)
        {
            Console.WriteLine(newGameStrategy); 
        }

        public void Visit(IOnDrawStrategy onDrawStrategy)
        {
            Console.WriteLine(onDrawStrategy); 
        }
        public abstract void DisplayWelcomeMessage();
        public abstract void DisplayCard(model.Card a_card);
        public abstract void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        public abstract void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        public abstract void DisplayGameOver(bool a_dealerIsWinner);
    }
}
