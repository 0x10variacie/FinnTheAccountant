﻿// Using
using System;
using System.Threading;

//// Variables
// Introductory page
string ichoice;

// Core
var key = "";
bool shouldConsoleClear = true;

//Programs
float? balance;         //Daily Expenses
float? dexpense;        //Daily Expenses

//Exit
string echoice;
//Core Methods

void Title(string titleText)
{
    Console.WriteLine(titleText.PadLeft(50,' '));
}

void UserPrompt (string prompt)
{
    Console.Write($"{prompt} > ");
    key = Console.ReadKey().KeyChar.ToString().ToLower();
    Console.WriteLine("\n");
}

void PressAnyKey()
{
    Console.Write("\nPress any key to continue . . .");
    Console.ReadKey(true).KeyChar.ToString();
    Console.WriteLine("\n");
}

void Exit()
{
    Console.WriteLine("Exit . . .");
    Environment.Exit(0);
}

//Utilities Methods
void ConsoleClear ()
{
    if (shouldConsoleClear)
    {
        Console.Clear();
    }
}


//Settings Checker
void Settings()
{
    ConsoleClear();
}
void Intro()
{
    Title("Finn the Accountant v1.0");
    Console.WriteLine(@"Hi there, my name is Finn the Accountant! Nice to meet you.
If you wonder why I'm called this way - my name is derived from FINances!
I'm created to help you with your budget and financial operations.
If you're stuck with budget planning or want me to help with understanding
financial actions - you can count on me!
Sadly, as I was just born, I can't guarantee I'll remember everything
once restarted...
So I'd recommend you to note everything down. But in the future, if my creator
learns, I'll let you store everything on file :)" + "\n");
    Console.Write("Now what are you waiting for? Come on, press any key to start me already (or press X to exit immediately)!! ");

    ichoice = Console.ReadKey(true).KeyChar.ToString();
    Thread.Sleep(1000);
    switch (ichoice.ToLower())
    {
        case "x":
            Exit();
            break;
        default:
            break;
    }

    Console.WriteLine("\n");
}
Intro();

//Program Skeleton
do
{
    Settings();
    Console.WriteLine("Okie-dokie, what can I do for you today?");
    //Menu
    Console.WriteLine(@"    1 - Daily Expenses
    2 - Settings
    3 - Help
    4 - About
    X - Exit
");

    UserPrompt("Please make your choice");

    //Prompt Initialization
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
                        Exit();
                        break;
                    case "n":
                        Settings();
                        validEChoice = true;
                        break;
                    default:
                        Settings();
                        Console.WriteLine("Didn't get you... please think again.");
                        validEChoice = false;
                        break;
                }
            }
            break;

        case "d":
            Settings();
            Title("You've entered the Developer Easter Egg!");
            Console.WriteLine("At the current moment, no skip feature included. To skip it faster, keep pressing Enter. I appreciate your understanding. -0x10variacie");
            UserPrompt("Press smth: ");
            Console.WriteLine("The UserPrompt feature tested successfully in the version 1.0 on 26.07.2025");
            break;

        case "i":
            Settings();
            Intro();
            break;

        case "1":
            Settings();
            Console.Write("You've selected Daily Expenses. How much do you have now? ");
            balance = float.Parse(Console.ReadLine());
            if (balance == 0)
            {
                Console.WriteLine(@"Well, no money means no expenses ¯\_(ツ)_/¯" + "\n");
                continue;
            }
            else if (balance < 0)
            {
                Console.WriteLine("You cannot have a negative balance; it's either something or nothing." + "\n");
                continue;
            }
            else if ((balance / 30) % 3 == 0)
            {
                Console.WriteLine($"You must have at least something to ask me how much you can spend daily" + "\n");
            }
            else
            {
                dexpense = (int) Convert.ToDouble(balance / 30);
                Console.WriteLine($"Given 30 days in a month, you should spend around {dexpense:C2} daily.\nIf you need to recheck daily expenses, just choose 1 again!");
                Thread.Sleep(1000);
                PressAnyKey();
                break;
            }
            break;

        case "2":
            Settings();
            Title("You've selected Settings");
            do
            {// comment or remove in case the Settings tab is documented
             //Console.WriteLine("Under construction . . .");

                //Console Clear
                Console.WriteLine($"1. Console Clear: {shouldConsoleClear}");

                //Help page
                Console.WriteLine("H: to show help for settings");

                UserPrompt("Choose the setting you want to change or press 0 to return");
                switch (key)
                {
                    case "1":
                        if (shouldConsoleClear)
                            shouldConsoleClear = false;
                        else shouldConsoleClear = true;
                        break;

                    case "h":
                        Settings();
                        Console.WriteLine(@"Console Clear - clears up the console after the user's prompt (True - clears up, False - doesn't clear up)");
                        PressAnyKey();
                        continue;
                }

                /*in the version 1.1, there should be one setting - Console Clear. The menu with the following options should be similar to the main menu.
                 The options are Yes and No. If the user set Yes, the console will be cleared after each operation is done.
                The setting should display the current status before the user makes a choice.*/

            } while (key.ToLower() != "0");
            PressAnyKey();
            break;

        case "3":
            Settings();
            Title("You've selected Help.");
Console.WriteLine(@"At this time, I have a few options for you to choose between.
Daily Expenses - type 1 in the main menu - allows to calculate how much you should spend daily
given 30 days in a calendar month. In the future, calendar months may vary from 28 to 31 days.
Settings - type 2 in the main menu - displays available settings.
Help - type 3 in the main menu - displays this page.
About - type 4 in the main menu - displays the information about me and my creator.
If you have any questions or suggestions, feel free to contact my creator - see the About tab.");
            Thread.Sleep(1000);
            PressAnyKey();
            break;

        case "4":
            Settings();
            Title("You've selected About.");
Console.WriteLine(@"Finn the Accountant v1.1
written by 0x10variacie

Feedback or suggestions are welcome:
https://github.com/0x10variacie

code written with C# on Windows 11");
            Thread.Sleep(1000);
            PressAnyKey();
            break;

        default:
            Console.WriteLine("Invalid input or not available yet\n");
            break;

    }
} while (key.ToLower() != "X");