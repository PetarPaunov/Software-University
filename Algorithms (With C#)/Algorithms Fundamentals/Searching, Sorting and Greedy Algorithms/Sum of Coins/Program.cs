﻿namespace Sum_of_Coins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var coins = new Queue<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .OrderByDescending(x => x));

            var target = int.Parse(Console.ReadLine());

            var usedCoins = new Dictionary<int, int>();
            var totalUsedCoins = 0;

            while (target > 0 && coins.Count > 0)
            {
                var currentCoin = coins.Dequeue();
                var count = target / currentCoin;

                if (count == 0)
                {
                    continue; 
                }

                usedCoins[currentCoin] = count; 
                totalUsedCoins += count;
                
                target %= currentCoin;
            }

            if (target <= 0)
            {
                Console.WriteLine($"Number of coins to take: {totalUsedCoins}");

                foreach (var coin in usedCoins)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}