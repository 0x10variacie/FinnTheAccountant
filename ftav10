// Using
using System;
using System.Threading;

// Variables (chronological order)
string ichoice;
var key = "";
float? balance;
bool smthTyped = false;
float? dexpense;
string echoice;


    Console.WriteLine("\t\t\tFinn the Accountant v1.0");
    Console.WriteLine("\nHi there, my name is Finn the Accountant! Nice to meet you.");
    Console.WriteLine("If you wonder why I'm called this way - my name is derived from FINances!");
    Console.WriteLine("I'm created to help you with your budget and financial operations.");
    Console.WriteLine("If you're stuck with budget planning or want me to help with understanding\nfinancial actions - you can count on me!");
    Console.WriteLine("Sadly, as I was just born, I can't guarantee I'll remember everything\nonce restarted...");
    Console.WriteLine("So I'd recommend you to note everything down. But in the future, if my creator\nlearns, I'll let you store everything on file :)");
    Console.Write("Now what are you waiting for? Come on, press any key to start me already (or press X to exit immediately)!! ");

ichoice = Console.ReadKey(true).KeyChar.ToString();
Thread.Sleep(1000);
switch (ichoice.ToLower())
{
    case "x":
        Console.WriteLine();
        Environment.Exit(0);
    default:
        break;
}

Console.WriteLine("\n");

do
{
    Console.WriteLine("Okie-dokie, what can I do for you today?");
    Console.WriteLine("\t 1 - Daily Expenses");
    Console.WriteLine("\t 2 - Help");
    Console.WriteLine("\t 3 - About");
    Console.WriteLine("\t X - Exit");

    key = Console.ReadKey().KeyChar.ToString();
    Console.WriteLine();

    switch (key)
    {
        case "x":
            bool validEChoice = false;
            while (!validEChoice)
                break;
            {
                Console.Write("Are you sure you want to quit?\nIf you didn't take notes during the use, you may lose changes! (Y/N) ");
                echoice = Console.ReadKey(true).KeyChar.ToString();
                Console.WriteLine();
                switch (echoice.ToLower())
                {
                    case "y":
                    case "x":
                        Environment.Exit(0);
                    case "n":
                        validEChoice = true;
                        break;
                    default:
                        Console.WriteLine("Didn't get you... please think again.");
                        validEChoice = false;
                }
            }
            break;

        case "1":
            Console.Write("You've selected Daily Expenses. How much do you have now? ");
            balance = float.Parse(Console.ReadLine());
            if (balance == 0)
            {
                Console.WriteLine(@"Well, no money means no expenses ¯\_(ツ)_/¯");
                continue;
            }
            else if (balance < 0)
            {
                Console.WriteLine("You cannot have a negative balance; it's either something or nothing.");
                continue;
            }
            else if ((balance / 30) % 3 == 0)
            {
                Console.WriteLine($"You must have at least something to ask me how much you can spend daily");
            }
            else
            {
                dexpense = (balance / 30) / 3;
                Console.WriteLine($"Given 30 days in a month, you should spend around ${dexpense} daily.");
                Console.WriteLine("If you need to recheck daily expenses, just choose 1 again!\n");
                Thread.Sleep(1000);
                break;
            }
            break;

        case "2":
            Console.WriteLine("\t\tYou've selected Help.\n");
            Console.WriteLine("At this time, I have a few options for you to choose between.");
            Console.WriteLine("Daily Expenses - type 1 in the main menu - allows to calculate how much you should spend daily");
            Console.WriteLine("given 30 days in a calendar month. In the future, calendar months may vary from 28 to 31 days.\n");
            Console.WriteLine("Help - type 2 in the main menu - displays this page.\n");
            Console.WriteLine("About - type 3 in the main menu - displays the information about me and my creator.\n");
            Console.WriteLine("If you have any questions or suggestions, feel free to contact my creator - see the About tab.\n");
            Thread.Sleep(1000);
            Console.WriteLine();
            break;

        case "3":
            Console.WriteLine("\t\tYou've selected About.");
            Console.WriteLine();
            Console.WriteLine("Finn the Accountant v1.0");
            Console.WriteLine("written by 0x10variacie");
            Console.WriteLine();
            Console.WriteLine("Feedback or suggestions are welcome:");
            Console.WriteLine("https://github.com/0x10variacie");
            Console.WriteLine();
            Console.WriteLine("code written with C# on Windows 11\n");
            Thread.Sleep(1000);
            break; 

        default:
            Console.WriteLine("Invalid input or not available yet\n");

    }
} while (key.ToLower() != "X");

// Total code lines: 130
