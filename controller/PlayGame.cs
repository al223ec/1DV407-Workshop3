using BlackJack.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace BlackJack.controller
{
    public interface IObserver
    {
        void Subscribe(IObservable observable);
        void Notify(); 
    }
    class PlayGame : IObserver
    {
            private view.IView a_view;
            private model.Game a_game;

            public PlayGame()
            {
                var rulesFactory = new model.rules.WeirdRulesFactory();   
                this.a_view = new view.SwedishView();//new view.SimpleView();

                rulesFactory.Accept(a_view);
                this.a_game = new model.Game(rulesFactory);

                Subscribe(a_game.GetPlayer());
                Subscribe(a_game.GetDealer());

                a_view.DisplayWelcomeMessage();
            }
            public bool Play()
            {
                if (a_game.IsGameOver())
                {
                    a_view.DisplayGameOver(a_game.IsDealerWinner());
                    a_view.ContinueOnEnter();
                }
                int input = a_view.GetInput();

                if (a_view.NewGame(input))
                {
                    a_game.NewGame();
                }
                else if (a_view.Hit(input))
                {
                    a_game.Hit();
                }
                else if (a_view.Stand(input))
                {
                    a_game.Stand();
                }

                return !a_view.Quit(input);
            }

            public void Subscribe(IObservable observable)
            {
                 observable.Subscribe(this); 
            }

            public void Notify()
            {
                Thread.Sleep(1000);
                a_view.Clear(); 
                a_view.DisplayWelcomeMessage();
                a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
                a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
            } 
    }
}
