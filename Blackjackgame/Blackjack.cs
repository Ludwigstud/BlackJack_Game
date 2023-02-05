using System;

namespace Blackjack
{
    class Blackjack
    {

        static int RandomCardPlayer()
        {
            Random randomPlayer = new Random();
            int cardPlayer = randomPlayer.Next(1, 11);
            return cardPlayer;
        }

        static int RandomCardDealer()
        {
            Random randomDealer = new Random();
            int cardDealer = randomDealer.Next(1, 11);
            return cardDealer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");
            int playerTotalCards = 0;
            int dealerTotalCard = 0;
            bool playing = true;

            while (playerTotalCards < 21 && dealerTotalCard < 21)
            {
                if (playing)
                {
                    Console.WriteLine("It's your turn. Hit or Stand?");
                    string playerPlay = Console.ReadLine().ToLower();
                    if (playerPlay == "hit")
                    {
                        int newCardPlayer = RandomCardPlayer();
                        Console.WriteLine("You were dealt a " + newCardPlayer);
                        playerTotalCards += newCardPlayer;
                        Console.WriteLine("Your total is now " + playerTotalCards);
                    }
                    else if (playerPlay == "stand")
                    {
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("You need to type hit or stand to play!");
                    }
                }
                else
                {
                    Console.WriteLine("Dealer's turn.");
                    while (dealerTotalCard < 17)
                    {
                        int newCardDealer = RandomCardDealer();
                        Console.WriteLine("Dealer was dealt a " + newCardDealer);
                        dealerTotalCard += newCardDealer;
                        Console.WriteLine("Dealer total is now " + dealerTotalCard);
                    }
                    if (dealerTotalCard > 21)
                    {
                        Console.WriteLine("Dealer busts. You win!");
                    }
                    else if (dealerTotalCard >= playerTotalCards)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                }
            }
            if (playerTotalCards > 21)
            {
                Console.WriteLine("You bust. Dealer wins.");
            }
            Console.WriteLine("You hit Blackjack! You win!");
        }

  


    }
}
