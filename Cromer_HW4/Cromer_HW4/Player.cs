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
 * Class: Player
 * static private fields: none
 * static public fields: none
 * non-static private fields: none
 * non-static public fields: CardHand ch
 * static private methods: none
 * non-static public methods: Player()
 * 
 * description: creates a Player object with CardHand field.
 * version/ date: 1.0, 7/26/2021
 */
    class Player
    {
        public CardHand ch = new CardHand("Player");

        public Player()
        {

        }
    }
}
