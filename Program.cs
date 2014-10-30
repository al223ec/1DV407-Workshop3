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
            controller.PlayGame controller = new controller.PlayGame();
 
            while (controller.Play());
        }
    }
}
