﻿using BlackJack.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    public interface IObservable 
    {
        void Subscribe(IObserver observer); 

    }
    class Player : IObservable
    {
        private IObserver observer; 
        private List<Card> m_hand = new List<Card>();

        public IEnumerable<Card> GetHand()
        {
            return m_hand.Cast<Card>();
        }

        public void Subscribe(IObserver observer)
        {
            this.observer = observer;
        }

        public void DealCard(Deck a_deck, bool show)
        {
            var c = a_deck.GetCard();
            c.Show(show);
            m_hand.Add(c);

            observer.Notify(); 
        }

        public void ClearHand()
        {
            m_hand.Clear();
        }

        public void ShowHand()
        {
            foreach (Card c in GetHand())
            {
                c.Show(true);
            }
        }

        public int CalcScore()
        {
            int[] cardScores = new int[(int)model.Card.Value.Count]
                {2, 3, 4, 5, 6, 7, 8, 9, 10, 10 ,10 ,10, 11};
            int score = 0;

            foreach(Card c in GetHand()) {
                if (c.GetValue() != Card.Value.Hidden)
                {
                    score += cardScores[(int)c.GetValue()];
                }
            }

            if (score > 21)
            {
                foreach (Card c in GetHand())
                {
                    if (c.GetValue() == Card.Value.Ace && score > 21)
                    {
                        score -= 10;
                    }
                }
            }

            return score;
        }

    }
}
