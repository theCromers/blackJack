/* homework 4 Blackjack game
 * 
 * Kayla Cromer
 * 
 * CMIS 1301: programming for games 1
 * 
 * Summer 2021
 * 
 * Requirements met: 
 * 1. watched the demo to see how the code was meant to be implemented in console
 * 2. System.Environment.Exit() implemented for final exit once win conditions are met and loop to Program.Main() where necessary
 * 3. shuffle and print a deck (the deck does shuffle however, I have issues with repeating elements) 
 * 4. created a Hand class that keeps the cards. adds to dealer hand and player hand respectively
 * 5. implemented a random class to choose from the shuffled deck and insert it to respective hands
 * 6. the maximum amount of cards drawn is 11 
 * 7. commenting template is implemented to the best of my ability 
 * 8. Game will run however as stated before I have an issue concerning the shuffled deck implementing repeating elements. 
 * Class: Program
 *
 * version/ date: 1.0, 7/26/2021
 */
using System;

namespace Blackjack
{
   enum Winner_ID { Tie, Player, Dealer, None, Undetermined };

    
    class Program
    {
        //static fields
        static Dealer dlr;
        static Player plr;
        //added deck.
        static public Deck dek;

        static string input;
        static bool is_winner = false;
        //give enum value, else default goes to first in list
        static Winner_ID winner = Winner_ID.Undetermined;
        //counts how many rounds cards have been dealt
        public static int count_deal = 0;

       // static string input;
       /*method: Main()
        * params: none
        * returns: void
        * class scope effects: gateway method
        * called methods: Console.WriteLine(), Hit(), Pass(), HitOrPass(), CheckForWinner()
        * 
        * description: runs the program, manages flow of the whole game
        */
        static void Main()
        {
            //initialized messages
            Console.WriteLine("Blackjack Rules:");
            Console.WriteLine("Player hits or passes to score closest to 21 without going over.");
            Console.WriteLine("Dealer hits until score >= 17. Then Dealer Holds. You are the Player.");

            //initialization user-defined objects
            dlr = new Dealer();
            plr = new Player();

            //dek initialized, constructor will shuffle and print to screen.
            dek = new Deck();
            //shuffle deck
            dek.Shuffle();

            //prints deck to double check
            dek.PrintDeck();

            //maximum of 11 dela spossiblew in single-deck blackjack
            //without game loop, using maimum possible card deals in blackjack
            for(int i = 0; i <= 9; i++)
            {
                HitOrPass();
                Console.WriteLine("-----");
                CheckForWinner();
            }
        }

        /* method: HitOrPass()
         * params: none
         * returns: void
         * class scope effects: input, is_winner, count_deal
         * called functions: Console.ReadLine(), Hit(), Pass(), Program.Main(),
         * System.Environment.Exit(-1), HitOrPass()
         * 
         * description: player inerface offered to decide whether to HitOrPass()
         * 
         * version/  date: 1.0, 7/26/2021
         */ 

        static void HitOrPass()
        {
            //interaction message
            Console.WriteLine("");
            Console.WriteLine("Type (h)it or (p)ass to play, (r)estart or (q)uit then type ENTER.");

            //receive input from player
            input = Console.ReadLine();

            //commands from player
            if(input == "h")
            {
                Console.WriteLine("");
                Console.WriteLine("You have decided to HIT.");
                Hit();
            }
            else if(input == "p")
            {
                Console.WriteLine("");
                Console.WriteLine("You have decided to PASS.");
                Pass();
            }
            else if (input == "r")
            {
                Console.WriteLine("");
                Console.WriteLine("You have decided to RESTART.");
                winner = Winner_ID.Undetermined;
                is_winner = false;
                count_deal = 0;
                Program.Main();
            }
            else if(input == "q")
            {
                Console.WriteLine("");
                Console.WriteLine("You have decided to QUIT.");
                //end program and quit 
                System.Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("Your entry is INVALID. Try again.");
                Console.WriteLine("");
                HitOrPass();
            }
        }

        /* method: Pass()
         * params: none
         * returns: void
         * class scope effects: Program.count_deal
         * called methods: Console.WriteLine(), dlr.ch.DrawCard(), dlr.ch.TallyHand(), 
         * plr.ch.TallyHand()
         * 
         * description: check if no winner, then draws dealer card. If winner then offers to restart game
         * 
         * version/ date: 1.0, 7/26/2021
         */

        static void Pass()
        {
            if(!is_winner && dlr.ch.score <= 17)
            {
                //adding one to count_deal for presenting "Deal count:" so player can use 1-indexed counting 
                Console.WriteLine("Deal count: " + (Program.count_deal + 1));
                Console.WriteLine("Dealer draws: ");

                dlr.ch.DrawCard(dek.shuffledDeck[(int)((count_deal * 2) / 13), (count_deal * 2) % 13]);
                Console.WriteLine("Player holds.");

                //incrementation after calculating 
                //which card to take from shuffled deck
                ++Program.count_deal;

                dlr.ch.TallyHand();
                plr.ch.TallyHand();
            } else if(!is_winner && dlr.ch.score > 17)
            {
                //adding one to count_deal for presenting "Deal count:" so player can use 1-indexed counting
                Console.WriteLine("Deal count: " + (Program.count_deal + 1));

                Console.WriteLine("Player holds.");
                Console.WriteLine("Dealer holds.");

                //incremenation after calculating
                //which card to take form shuffled deck
                ++Program.count_deal;

                dlr.ch.TallyHand();
                plr.ch.TallyHand();
            }
            else
            {
                Console.WriteLine("A winner has already been determined.");
                Console.WriteLine("(q)uit or (r)estart to play again.");
                input = Console.ReadLine();
                switch(input)
                {
                    case "q": System.Environment.Exit(1);
                        break;
                    case "r":
                        winner = Winner_ID.Undetermined;
                        is_winner = false;
                        Program.Main();
                        count_deal = 0;
                        break;
                    default:
                        Console.WriteLine("Your entry is INVALID.");
                        Pass();
                        break;
                }
            }
        }
        /* method: Hit()
         * params: none 
         * returns: void
         * class scope effects: Program.count_deal
         * called methods: Console.WriteLine(), dlr.ch.TallyHand(), plr.ch.TallyHand(), System.Environment.Exit(1), 
         * Hit(), Program.Main()
         * 
         * description: if no winner, player elects to draw a new card. If winner determined, offer to restart game or quit
         * 
         * version/ date: 1.0, 7/26/2021
         */

        static void Hit()
        {
            //if no winner yet, method contents run
            if (!is_winner)
            {
                //moved the count_deal increment down to after card is dealt from shuffled deck
                //adding one to count_deal for presenting "Deal count:" so player can use 1-indexed counting 
                Console.WriteLine("Deal count: " + (Program.count_deal + 1));

                Console.WriteLine("Dealer draws: ");
                dlr.ch.DrawCard(dek.shuffledDeck[(int)((count_deal * 2) / 13), (count_deal * 2) % 13]);

                Console.WriteLine("Player draws: ");
                plr.ch.DrawCard(dek.shuffledDeck[(int)((count_deal * 2 + 1) / 13), (count_deal * 2 + 1) % 13]);

                ++Program.count_deal;

                dlr.ch.TallyHand();
                plr.ch.TallyHand();
            }else
            {
                Console.WriteLine("A winner has already been determined.");
                Console.WriteLine("(q)uit or (r)estart to play again.");
                input = Console.ReadLine();
                switch (input)
                {
                    case "q":
                        System.Environment.Exit(1);
                        break;
                    case "r":
                        winner = Winner_ID.Undetermined;
                        is_winner = false;
                        count_deal = 0;
                        Program.Main();
                        break;
                    default:
                        Console.WriteLine("Your entry is INVALID.");
                        Hit();
                        break;
                }
            }
        }

        /* method: CheckForWinner()
         * params: none
         * returns: none
         * class scope effects: is_winner, winner, dlr.ch.score, plr.ch.score
         * called functions: Console.WriteLine()
         * 
         * description: checks for a winner in the game
         * 
         * version/ date: 1.0, 7/26/2021
         */

        static void CheckForWinner()
        {
            //if no winner yet, method contents run
            if(!is_winner)
            {
                //post score
                Console.WriteLine("Dealer score: " + dlr.ch.score);
                Console.WriteLine("Player score: " + plr.ch.score);

                //checks all possible end game conditions
                if(dlr.ch.score <= 21 && plr.ch.score <= 21)
                {
                    if(dlr.ch.score ==21 && plr.ch.score ==21)
                    {
                        is_winner = true;
                        winner = Winner_ID.Tie;
                    }
                    else if(dlr.ch.score == 21 && plr.ch.score != 21)
                    {
                        is_winner = true;
                        winner = Winner_ID.Dealer;
                    }
                    else if(plr.ch.score == 21 && dlr.ch.score != 21)
                    {
                        is_winner = true;
                        winner = Winner_ID.Player;
                    }
                    else if(plr.ch.score > 21 && plr.ch.score <= 21)
                    {
                        is_winner = true;
                        winner = Winner_ID.Player;
                    }
                    else if(plr.ch.score > 21 && dlr.ch.score <= 21)
                    {
                        is_winner = true;
                        winner = Winner_ID.Dealer;
                    }
                }
            }
        }
    }
}
