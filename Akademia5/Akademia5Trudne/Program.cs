using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia5trudne
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Game.round += 1;
                Random rnd = new Random();
                int dice1_1 = rnd.Next(1, 7);
                int dice1_2 = rnd.Next(1, 7);
                int dice2_1 = rnd.Next(1, 7);
                int dice2_2 = rnd.Next(1, 7);
                Console.WriteLine("==================== ROUND {0} ====================", Game.round);
                Console.WriteLine("PLAYER_1           {0}    vs   {1}          PLAYER_2", dice1_1 + dice1_2, dice2_1 + dice2_2);
                Console.WriteLine();
                Game.listPlayerTwo.Add(dice2_1 + dice2_2);
                Game.listPlayerOne.Add(dice1_1 + dice1_2);
                if (dice1_1 + dice1_2 > dice2_1 + dice2_2)
                {
                    Console.WriteLine("                   PLAYER_1 WON                    ");
                    Game.listRound.Add(1);
                }
                else if (dice1_1 + dice1_2 < dice2_1 + dice2_2)
                {
                    Console.WriteLine("                   PLAYER_2 WON                    ");
                    Game.listRound.Add(2);
                }
                else
                {
                    Console.WriteLine("                       DRAW                       ");
                    Game.listRound.Add(0);
                }
                Console.WriteLine("[SPACE] - Next round");
                Console.WriteLine("[H] - History");
                Console.WriteLine("[Q] - Quit");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                }
                if (info.KeyChar == 'h')
                {
                    Console.Clear();
                    for (int i = 0; i < Game.listRound.Count; i++)
                    {
                        Console.WriteLine("Round {0}: {1}:{2}",i+1,Game.listPlayerOne[i],Game.listPlayerTwo[i]);
                    }
                    Console.WriteLine("[SPACE] - Next round");
                    Console.WriteLine("[Q] - Quit");
                    info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                    }
                    if (info.KeyChar == 'q')
                    {
                        break;
                    }
                }
                if (info.KeyChar == 'q')
                {
                    break;
                }
            }
        }
    }
}
