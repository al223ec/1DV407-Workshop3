using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    abstract class BaseView 
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
            return (int)System.Console.ReadKey().KeyChar;
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
    
    }
}
