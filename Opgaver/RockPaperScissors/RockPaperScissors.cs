using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver;

public class RockPaperScissors
{
    public static void Run()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Velkommen til Sten, Saks, Papir!");
        Console.WriteLine("Se opgaven her - https://mercantec.notion.site/sten-saks-papir");
        Game();
    }


    public static void Game()
    {
        Console.WriteLine("Indtast 1 for sten 2 for saks 3 for papir");
        Options player = GetPlayerChoice();
        Options computer = GetComputerChoice();
        CompareResults(player, computer);
    }

    static Options GetPlayerChoice()
    {
        Console.WriteLine("Indtast 1 for sten, 2 for saks, 3 for papir");
        int input = int.Parse(Console.ReadLine());
        return (Options)input;
    }

    static Options GetComputerChoice()
    {
        Random rnd = new Random();
        return (Options)rnd.Next(1, 4);
    }

    public static void CompareResults(Options player, Options computer)
    {
        if (player == computer)
        {
            Console.WriteLine($"Du valgte {player} og computeren valgte {computer}");
            Console.WriteLine("Draw!");
        }
        else if (player == Options.Rock && computer == Options.Scissors)
        {
            Console.WriteLine($"Du valgte {player} og computeren valgte {computer}");

            Console.WriteLine("You win!");
        }
        else if (player == Options.Scissors && computer == Options.Paper)
        {
            Console.WriteLine($"Du valgte {player} og computeren valgte {computer}");
            Console.WriteLine("You win!");
        }
        else if (player == Options.Paper && computer == Options.Rock)
        {
            Console.WriteLine("Computeren havde: " + computer);
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computeren havde: " + computer);
            Console.WriteLine("Computer wins!");
        }
    }

    public enum Options
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }
}