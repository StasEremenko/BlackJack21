﻿using System;

namespace BlackJack21
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int playerCardValue = 0;
            int computerCardValue = 0;

            Random random = new Random();

            playerCardValue += random.Next(1, 12);            
            playerCardValue += random.Next(1, 12);          
            if (playerCardValue > 21)
            {
                playerCardValue -= 10;                
            }
            
                
            computerCardValue += random.Next(1, 12);            
            computerCardValue += random.Next(1, 12);            
            if (computerCardValue > 21)
            {
                computerCardValue -= 10;
            }


            // Players turn
            while(true)
            {
                if (playerCardValue == 21)
                {
                    Console.WriteLine("You are at 21!!!");
                    break;
                }
                Console.WriteLine("My Card Value: " + playerCardValue.ToString() + " Hit?");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    playerCardValue += random.Next(1, 12);                    
                    if (playerCardValue > 21)
                    {
                        Console.WriteLine("You Busted!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (answer == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorect response, try agin!");
                    continue;
                }
            }


            //Dealers turn
            Console.WriteLine("Players card value is " + playerCardValue.ToString());
            if (playerCardValue <= 21)
            {
                while (computerCardValue < 21 && computerCardValue < playerCardValue)
                {
                    computerCardValue += random.Next(1, 12);                    
                }
                if (computerCardValue == playerCardValue)
                {
                    Console.WriteLine("Player and dealer have tied!");
                }
                else if (playerCardValue < computerCardValue && computerCardValue <= 21)
                {
                    Console.WriteLine("Computer has won!");
                }
                else if (computerCardValue > 21)
                {
                    Console.WriteLine("Computer has busted, player has won!");
                }
                else if (computerCardValue == 21)
                {
                    Console.WriteLine("Computer has won!");
                }
            }
            else
            {
                Console.WriteLine("Computer has won, player has busted!");
            }
            Console.WriteLine("Dealers value: " + computerCardValue.ToString());

            Console.ReadKey();
        }

    }
}
