/* homework 4 Balckjack game
 * 
 * Kayla Cromer
 * 
 * CMIS 1301: programming for games 1
 * 
 * Summer 2021
 * 
 * Class: Card
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public enum Suit { S, C, H, D };

    public enum Rank { _A = 1, _2 = 2, _3, _4, _5, _6, _7, _8, _9, _10, _J, _Q, _K};
    class Card
    {
        public int value;

        //added Suit, Rank and is_used as fields
        public Suit sut;
        public Rank rnk;
        public bool is_used = false;
        /* Function: Card Constructor
         * Params: none
         * returns: card object
         * class scope effects: sut and rnk are given values at instantiation
         * called functions: Shuffled(), Console.WriteLine()
         * 
         * Description: instantiates the Card object
         * 
         * version/ date: 1.0 7/26/2021
         */

        public Card()
        {
            //load default
            value = 0;
        }
        // new constructor

        public Card(Suit s, Rank r)
        {
            sut = s;
            rnk = r;
          

            //notice type conversiton of enum
            value = Math.Min((int)rnk, 10); //sets clamp for value at 10
        }
    }
}
