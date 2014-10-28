using BlackJack.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            //var dealer = new Dealer(new BlackJack.model.rules.RulesFactory());
            //var player = new Player();


            //model.Game game = new model.Game(dealer, player);
            model.Game game = new model.Game();
            view.IView view = new view.SwedishView();//new view.SimpleView();
            controller.PlayGame controller = new controller.PlayGame(game, view);

            //controller.Subscribe(player);
            //controller.Subscribe(dealer); 
            while (controller.Play());
        }
    }
}
