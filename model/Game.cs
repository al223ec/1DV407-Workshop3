﻿using BlackJack.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Game
    {
        private model.Dealer m_dealer;
        private model.Player m_player;

        public Game(rules.RulesFactory a_rulesFactory)
        {
            m_dealer = new Dealer(a_rulesFactory);
            m_player = new Player();
        }
        public Game(model.Dealer a_dealer, model.Player a_player)
        {
            m_dealer = a_dealer;
            m_player = a_player;
        }

        public bool IsGameOver()
        {
            return m_dealer.IsGameOver();
        }

        public bool IsDealerWinner()
        {
            return m_dealer.IsDealerWinner(m_player);
        }

        public bool NewGame()
        {
            return m_dealer.NewGame(m_player);
        }

        public bool Hit()
        {
            return m_dealer.Hit(m_player);
        }


        public bool Stand()
        {
            // TODO: Implement this according to Game_Stand.sequencediagram
            return m_dealer.Stand(); 
        }

        public IEnumerable<Card> GetDealerHand()
        {
            return m_dealer.GetHand();
        }

        public IEnumerable<Card> GetPlayerHand()
        {
            return m_player.GetHand();
        }

        public int GetDealerScore()
        {
            return m_dealer.CalcScore();
        }

        public int GetPlayerScore()
        {
            return m_player.CalcScore();
        }
    
        //Halv privacy leaks
        public IObservable GetPlayer()
        {
 	        return m_player;
        }
        public IObservable GetDealer()
        {
 	        return m_dealer;
        }

    }
}
