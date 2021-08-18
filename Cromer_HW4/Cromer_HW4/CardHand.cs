using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    /* homework 4 Balckjack game
 * 
 * Kayla Cromer
 * 
 * CMIS 1301: programming for games 1
 * 
 * Summer 2021
 * 
 * Class: CardHand
 * 
 */
    class CardHand
    {
        public string owner_type;

        //initializing 11 empty cards for up to 11 dealings actual cards

        Card card00 = new Card();
        Card card01 = new Card();
        Card card02 = new Card();
        Card card03 = new Card();
        Card card04 = new Card();
        Card card05 = new Card();
        Card card06 = new Card();
        Card card07 = new Card();
        Card card08 = new Card();
        Card card09 = new Card();
        Card card10 = new Card();

        public int score = 0;

        public CardHand(string obj_type)
        {
            owner_type = obj_type;
        }

        /* mathod: DrawCard()
         * params: Card crd
         * returns: void
         * class scope effects: Card card00 to card10
         * called functions: Console.WriteLine()
         * 
         * description: takes as parameter a card and assigns it to one of the empty 11 cards possible
         * for any given hand. Prints the selection to the console.
         * 
         * version/ date: 1.0 7/26/2021
         */

        public void DrawCard(Card crd)
        {
            //loads card value with suit/ rank
            //given in parameter and prints to console
            if (Program.count_deal ==0) //Program.count_deal == 0. start at 0
            {
                card00 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 1)
            {
                card01 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if (Program.count_deal == 2)
            {
                card02 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 3)
            {
                card03 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 4)
            {
                card04 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 5)
            {
                card05 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 6)
            {
                card06 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 7)
            {
                card07 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 8)
            {
                card08 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 9)
            {
                card09 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal == 10)
            {
                card10 = crd;
                Console.WriteLine("Suit: " + crd.sut + ", Rank:" + crd.rnk);
            }
            else if(Program.count_deal > 11)
            {
                Console.WriteLine("The maximum number of cards have been drawn.");
            }
        }
        /* method: TallyHand()
         * params: none
         * returns: void
         * class scope effects: score
         * called functions: none
         * 
         * description: adds up all the card values in hand
         * 
         * version/ date: 1.0, 7/26/2021
         */

        public void TallyHand()
        {
            //restricts tally to Player CardHand
            //Dealer must hold at first sum equal or greater than 17
            if(score <= 17 || this.owner_type == "Player")
            {
                //sum all card values stored
                score = card00.value + card01.value + card02.value + card03.value +
                    card04.value + card05.value + card06.value + card07.value +
                    card08.value + card09.value + card10.value;
            }
        }
    }
}
