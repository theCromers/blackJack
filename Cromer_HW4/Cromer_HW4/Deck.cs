/* HOMEWORK 4 PART 2: Blackjack Game
 * 
 * KAYLA CROMER
 * 
 * CMIS 1301: PROGRAMMING FOR GAMES 1
 * 
 * SUMMER 2021
 * 
 * CLASS: Deck
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    
    class Deck
    {
        //declare and initialize empty deck array 4 x 13 unique cards
        public Card[,] shuffledDeck = new Card[4, 13];

        //declare and initalize 4 rows x 13 cols
        public Card[,] masterOrderDeck = new Card[4, 13]
        {
            //row 0, 13 cols - Spades
            {new Card(Suit.S,Rank._A),new Card(Suit.S,Rank._2),new Card(Suit.S,Rank._3),
                new Card(Suit.S,Rank._4),new Card(Suit.S,Rank._5),new Card(Suit.S,Rank._6),
                new Card(Suit.S,Rank._7),new Card(Suit.S,Rank._8),new Card(Suit.S,Rank._9),
                new Card(Suit.S,Rank._10),new Card(Suit.S,Rank._J),new Card(Suit.S,Rank._Q),
                new Card(Suit.S,Rank._K)},
            //row 1, 13 cols - Clubs
            {new Card(Suit.C,Rank._2),new Card(Suit.C,Rank._2),new Card(Suit.C,Rank._3),
                new Card(Suit.C,Rank._4),new Card(Suit.C,Rank._5),new Card(Suit.C,Rank._6),
                new Card(Suit.C,Rank._7),new Card(Suit.C,Rank._8),new Card(Suit.C,Rank._9),
                new Card(Suit.C,Rank._10),new Card(Suit.C,Rank._J),new Card(Suit.C,Rank._Q),
                new Card(Suit.C,Rank._K)},

            //row 2, 13 cols - Hearts
            {new Card(Suit.H,Rank._A),new Card(Suit.H,Rank._2),new Card(Suit.H,Rank._3),
                new Card(Suit.H,Rank._4),new Card(Suit.H,Rank._5),new Card(Suit.H,Rank._6),
                new Card(Suit.H,Rank._7),new Card(Suit.H,Rank._8),new Card(Suit.H,Rank._9),
                new Card(Suit.H,Rank._10),new Card(Suit.H,Rank._J),new Card(Suit.H,Rank._Q),
                new Card(Suit.H,Rank._K)},

            //row 3, 13 cols - Diamonds
            {new Card(Suit.D, Rank._A), new Card(Suit.D,Rank._2),new Card(Suit.D,Rank._3),
                new Card(Suit.D, Rank._4), new Card(Suit.D,Rank._5),new Card(Suit.D,Rank._6),
                new Card(Suit.D, Rank._7), new Card(Suit.D,Rank._8),new Card(Suit.D,Rank._9),
                new Card(Suit.D,Rank._10), new Card(Suit.D,Rank._J),new Card(Suit.D,Rank._Q),
                new Card(Suit.D,Rank._K)},
        };

        /* Function: Deck Constructor
         * params: none
         * returns: deck object
         * class scope effects: none
         * called functions: Shuffle(), Console. WriteLine()
         * 
         * Description: instantiates Deck object
         * 
         * version/date: 1.0 , 7/26/2021
         */

        public Deck()
        {
            Shuffle();
        }

        /* function: PrintDeck()
         * params: none
         * returns: void
         * class scope effects: none
         * 
         * description: prints shuffledDeck array
         * 
         * version/ date: 1.0, 7/26/2021 
         */

        public void PrintDeck()
        {
            //prints out shuffledDeck based on (i) ascending

            for(int i = 0; i <= 51; i++)
            {
                Console.WriteLine(i + "[" + (int)(i / 13) + "," + i % 13 + "]"
                    + " Suit: " + shuffledDeck[(int)(i / 13), i % 13].sut
                    + " Rank: " + shuffledDeck[(int)i / 13, i % 13].rnk);
                
            }

            Console.WriteLine("-----");
        }

        /* function: Shuffle()
         * params: none
         * returns: void
         * class scope effects: initialized shuffleDeck
         * called functions: Shuffle(), Console.WriteLine()
         * 
         * description: initializes shuffleDeck, displays how many times SelectRandomCard() was called, 
         * this will be good to double check the blackjack game
         * 
         * version/ date: 1.0, 7/26/2021
         */

        public void Shuffle()
        {
            //done using 2d nested loop

            //filling row 0 of shuffled deck
            shuffledDeck[0, 0] = InsertRandomCard(); 
            shuffledDeck[0, 1] = InsertRandomCard();
            shuffledDeck[0, 2] = InsertRandomCard();
            shuffledDeck[0, 3] = InsertRandomCard();
            shuffledDeck[0, 4] = InsertRandomCard();
            shuffledDeck[0, 5] = InsertRandomCard();
            shuffledDeck[0, 6] = InsertRandomCard();
            shuffledDeck[0, 7] = InsertRandomCard();
            shuffledDeck[0, 8] = InsertRandomCard();
            shuffledDeck[0, 9] = InsertRandomCard();
            shuffledDeck[0, 10] = InsertRandomCard();
            shuffledDeck[0, 11] = InsertRandomCard();
            shuffledDeck[0, 12] = InsertRandomCard();

            //filling row 1
            shuffledDeck[1, 0] = InsertRandomCard();
            shuffledDeck[1, 1] = InsertRandomCard();
            shuffledDeck[1, 2] = InsertRandomCard();
            shuffledDeck[1, 3] = InsertRandomCard();
            shuffledDeck[1, 4] = InsertRandomCard();
            shuffledDeck[1, 5] = InsertRandomCard();
            shuffledDeck[1, 6] = InsertRandomCard();
            shuffledDeck[1, 7] = InsertRandomCard();
            shuffledDeck[1, 8] = InsertRandomCard();
            shuffledDeck[1, 9] = InsertRandomCard();
            shuffledDeck[1, 10] = InsertRandomCard();
            shuffledDeck[1, 11] = InsertRandomCard();
            shuffledDeck[1, 12] = InsertRandomCard();

            //filling row 2

            shuffledDeck[2, 0] = InsertRandomCard();
            shuffledDeck[2, 1] = InsertRandomCard();
            shuffledDeck[2, 2] = InsertRandomCard();
            shuffledDeck[2, 3] = InsertRandomCard();
            shuffledDeck[2, 4] = InsertRandomCard();
            shuffledDeck[2, 5] = InsertRandomCard();
            shuffledDeck[2, 6] = InsertRandomCard();
            shuffledDeck[2, 7] = InsertRandomCard();
            shuffledDeck[2, 8] = InsertRandomCard();
            shuffledDeck[2, 9] = InsertRandomCard();
            shuffledDeck[2, 10] = InsertRandomCard();
            shuffledDeck[2, 11] = InsertRandomCard();
            shuffledDeck[2, 12] = InsertRandomCard();

            //filling row 3 

            shuffledDeck[3, 0] = InsertRandomCard();
            shuffledDeck[3, 1] = InsertRandomCard();
            shuffledDeck[3, 2] = InsertRandomCard();
            shuffledDeck[3, 3] = InsertRandomCard();
            shuffledDeck[3, 4] = InsertRandomCard();
            shuffledDeck[3, 5] = InsertRandomCard();
            shuffledDeck[3, 6] = InsertRandomCard();
            shuffledDeck[3, 7] = InsertRandomCard();
            shuffledDeck[3, 8] = InsertRandomCard();
            shuffledDeck[3, 9] = InsertRandomCard();
            shuffledDeck[3, 10] = InsertRandomCard();
            shuffledDeck[3, 11] = InsertRandomCard();
            shuffledDeck[3, 12] = InsertRandomCard();

            //shows how many times SelectRandomCard() was called to get all cards in masterOrderedDeck[]
            Console.WriteLine("selection_count: " + selection_count);
        }

        /* Function: InsertRandomCard
         * params: none
         * returns: Card
         * class scope effects: changes value of masterOrderedDeck.isUsed
         * called functions: SelectRandomCard()
         * 
         * description: calls SelectRandomCard() to find masterOrderDeck[r, c].isUsed as false value,
         * then changes found array element Card to true and uses random number for insertion as assignment
         * of card from masterOrderDeck[r, c] to shuffledDeck[r, c]
         * 
         * version/ date: 1.0, 7/26/2021
         */

        //used to store random number after converted from rand.obj.Next dow in method SelectRandom()
        int rand_num;

        Card InsertRandomCard()
        {
            //declares and initializes empty Card
            Card randomCard = new Card();
            Random rng= new Random();
            rand_num = rng.Next(52);
            //calls random number to save in class variable 
            masterOrderDeck[(int)(rand_num / 13), (int)(rand_num % 13)].is_used = true;

            //assigns card selected randomly to masterOrderDeck to randomCard
            //random card returned and assigned to shuffleDek elements

            randomCard = masterOrderDeck[(int)(rand_num / 13), (int)(rand_num % 13)];

            return randomCard;
        }

        /* function: SelectRandomCard()
         * params: none
         * returns: void
         * class scope effects: changes value of MasterOrderDeck.isUsed
         * called functions: SelectRandomCard()
         * 
         * description: selects random number from 0-51, checks for false in masterOrderDeck[r,c].isUsed,
         * if finds false value, then changes to true and uses random number
         * 
         * version/ date: 1.0 7/26/2021
         */
        //used for bug hunting , used to randomly select each index in masterOrderDeck in unused state

        int selection_count = 0;

        //how many failed attempts made to get unuseed random number 0-51
        int counter_sel_rand = 0;

        Random rand_obj = new Random();

        void SelectRandomCard()
        {
            //counts how many times SelectRandom() is run
            selection_count++;

            //stores current random number from seed
            rand_num = rand_obj.Next(52);

            //runs CheckSelection with stored rand_num
            //if true keeps selection, compiler runs. 
            if(CheckRandomSelection(rand_num))
            {
                //resets counter of failures to select index of element with is_used = true
                counter_sel_rand = 0;
                return;
            }
            else
            {
                //counts failures to select index of element with is_used = true. Loops back on itself
                counter_sel_rand++;
                SelectRandomCard();
            }
        }

        /* function: CheckRandomSelection()
         * params: int
         * returns: bool
         * class scope effects: none
         * 
         * description: checks if the random number, receives as elem_num for masterOrderDeck was never used before. 
         * Checks if masterOrderDeck[r, c].isUsed was false or true
         * 
         * version/date: 1.0, 7/26/2021
         */

        bool CheckRandomSelection(int elem_num)
        {
            //sees if element number in elem_num in masterOrderDeck[] array. has is_used value that is false
            if(!masterOrderDeck[(int)elem_num / 13, elem_num % 13].is_used)
            {
                //return true return to confirm that the elem_num has is_used set to false
                return true;
            }
            else
            {
                //return false value to indicate that is_used of elem_num is set to true and already used
                return false;
            }
        }
    }
}
