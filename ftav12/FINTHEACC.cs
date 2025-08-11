// Using
using System;
using System.Numerics;
using System.Threading;

//// Variables
// Introductory page
string ichoice;

// Core
var key = "";
bool shouldConsoleClear = true;

//Programs
float? balance = null;         //Daily Expenses
float? dexpense = null;        //Daily Expenses
float? inval = null;           //Investment Value Calculator
float? intval = null;          //Investment Value Calculator
int intper = 0;                //Investment Value Calculator 
int? perval = null;            //Investment Value Calculator

//Exit
string echoice;
//Core Methods

void Title(string titleText)
{
    Console.WriteLine(titleText.PadLeft(50, ' '));
}

void UserPrompt(string prompt)
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

//Basic Utilities (before introducting as two separate classes)
void ftaDailyExpenses()
{
    Preferences();
    do
    {
        Console.Write("You've selected Daily Expenses. How much do you have now? ");
        string balanceInput = Console.ReadLine();
        if (!float.TryParse(balanceInput, out float tempBalance))
            continue;
        balance = tempBalance;
    } while (balance == null);

    if (balance == 0)
    {
        Console.WriteLine(@"Well, no money means no expenses ¯\_(ツ)_/¯" + "\n");
    }
    else if (balance < 0)
    {
        Console.WriteLine("You cannot have a negative balance; it's either something or nothing." + "\n");
    }
    else
    {
        dexpense = (int)Convert.ToDouble(balance / 30);
        Console.WriteLine($"Given 30 days in a month, you should spend around {dexpense:C2} daily.\nIf you need to recheck daily expenses, just choose 1 again!");
        Thread.Sleep(1000);
        PressAnyKey();
    }
}

void ftaInvestCalc()
{
    Preferences();
    Title("You've selected Investment Value Calculator.");

    do
    {
        Console.Write("Please enter the investment value: ");
        string invalInput = Console.ReadLine();
        if (!float.TryParse(invalInput, out float tempInval))
            continue;
        inval = tempInval;
    } while (inval == null && inval > 0);

    do
    {
        Console.Write("Please enter the interest in %: ");
        string intvalInput = Console.ReadLine();
        if (!float.TryParse(intvalInput, out float tempIntval))
            continue;
        intval = tempIntval;
    } while (intval == null && intval > 0);

    do
    {
        Console.Write("Please enter the period in full years: ");
        string pervalInput = Console.ReadLine();
        if (!int.TryParse(pervalInput, out int tempPerval))
            continue;
        perval = tempPerval;
    } while (perval == null && perval > 0);

    int n = intper;
    do
    {
        UserPrompt("Choose the preferred rate: Annually, Quartely, Monthly, Weekly, Daily");
        switch (key.ToLower())
        {
            case "a": n = 1; break;
            case "q": n = 4; break;
            case "m": n = 12; break;
            case "w": n = 52; break;
            case "d": n = 365; break;
        }
    } while (key == null);

    Console.WriteLine();
    float r = intval.Value / 100f;
    int t = perval.Value;
    float fv = inval.Value * (float)Math.Pow(1 + r / n, n * t);
    float pv = fv / (float)Math.Pow(1 + r / n, n * t);

    Console.WriteLine($@"Future value: {fv}
Present Value: {pv}");
    PressAnyKey();
}

//Utilities Methods
void ConsoleClear()
{
    if (shouldConsoleClear)
    {
        Console.Clear();
    }
}

//Preferences Checker
void Preferences()
{
    ConsoleClear();
}
void Intro()
{
    Title("Finn the Accountant v1.2");
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
    Preferences();
    Console.WriteLine("Okie-dokie, what can I do for you today?");
    //Menu
    Console.WriteLine(@"    S - Savings
    I - Investments
    P - Preferences
    H - Help
    A - About
    X - Exit
");

    UserPrompt("Please make your choice");

    //Prompt Initialization
    switch (key.ToLower())
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
                        Preferences();
                        validEChoice = true;
                        break;
                    default:
                        Preferences();
                        Console.WriteLine("Didn't get you... please think again.");
                        validEChoice = false;
                        break;
                }
            
            break;
    }

        case "d":
            // the Developer Easter Egg - when used to read about easter eggs aged 11 :D
            Preferences();
            Title("You've entered the Developer Easter Egg!");
            Console.WriteLine("At the current moment, no skip feature included. To skip it faster, keep pressing Enter. I appreciate your understanding. -0x10variacie");
            UserPrompt("Press smth: ");
            Console.WriteLine("The UserPrompt feature tested successfully in the version 1.0 on 26.07.2025");
            break;

        case "q":
            // due to conflict with I button for Investments, the easter egg has been changed from I to Q.
            // btw if you're reading this, a small chest is easy to open :DD
            Preferences();
            Intro();
            break;

        case "s":
            Preferences();
            Title("*** SAVINGS ***");
            do
            {
                //List all possible savings utilities
                Console.WriteLine(@"1 - Daily Expenses");

                UserPrompt("Choose a utility you'd like to run or press 0 to return to the main menu");

                switch (key.ToLower())
                {
                    case "1":
                        ftaDailyExpenses();
                        break;
                }

            } while (key.ToLower() != "0") ;
            break;

        case "i":
            Preferences();
            Title("*** INVESTMENTS ***");

            do
            {
                Console.WriteLine(@"1 - Investment Value Calculator");
                UserPrompt("Choose a utility you'd like to run or press 0 to return to the main menu");

                switch (key.ToLower())
                {
                    case "1":
                        ftaInvestCalc();
                        break;
                }
            } while (key.ToLower() != "0") ;
            break;

        case "p":
            Preferences();
            Title("You've selected Preferences");
            do
            {

                //Console Clear
                Console.WriteLine($"1. Console Clear: {shouldConsoleClear}");

                //Help page
                Console.WriteLine("H: to show help for Preferences");

                UserPrompt("Choose the preference you want to change or press 0 to return");
                switch (key.ToLower())
                {
                    case "1":
                        if (shouldConsoleClear)
                            shouldConsoleClear = false;
                        else shouldConsoleClear = true;
                        break;

                    case "h":
                        Preferences();
                        Console.WriteLine(@"Console Clear - clears up the console after the user's prompt (True - clears up, False - doesn't clear up)");
                        PressAnyKey();
                        continue;
                }

            } while (key.ToLower() != "0");
            PressAnyKey();
            break;

        case "h":
            Preferences();
            Title("You've selected Help.");
            Console.WriteLine(@"Savings - type S in the main menu - savings-oriented utilities
Investments - type I in the main menu - investment-oriented utilities
(detailed instructions per each section TBS)

Daily Expenses - type 1 in the Investments menu - allows to calculate how much you should spend 
daily given 30 days in a calendar month. In the future, calendar months may vary from 28 to 31
days.

Preferences - type P in the main menu - displays available preferences.
Help - type H in the main menu - displays this page.
About - type A in the main menu - displays the information about me and my creator.
If you have any questions or suggestions, feel free to contact my creator - see the About tab.");
            Thread.Sleep(1000);
            PressAnyKey();
            break;

        case "a":
            Preferences();
            Title("You've selected About.");
            Console.WriteLine(@"Finn the Accountant v1.2
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