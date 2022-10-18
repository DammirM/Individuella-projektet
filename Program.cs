using System;
using System.Threading;

namespace Individuella_projektet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Damir SUT22
            // Methods are explained in the Methods
            
            // Array of Users
            string[,] Users = new string[5, 2];
            {

                Users[0, 0] = "Damir"; Users[0, 1] = "1234";
                Users[1, 0] = "Banan"; Users[1, 1] = "2345";
                Users[2, 0] = "Äpple"; Users[2, 1] = "3456";
                Users[3, 0] = "Päron"; Users[3, 1] = "4567";
                Users[4, 0] = "Apelsin"; Users[4, 1] = "5678";

            };

            // Array of Accounts, NOT a god choice of array should have taken 2d array and loop

            decimal[] Damir = { 100.50M, 50, };
            decimal[] Banan = { 323.99M, 549.90M };
            decimal[] Äpple = { 8199, 2999, };
            decimal[] Päron = { 345.78M, 66 };
            decimal[] Apelsin = { 99.34M };

            // loop for whole program
            bool ShutDown = true;
            // switch loop
            bool UsersUse = false;

            do
            {
             Console.WriteLine("Välkommen till Spacebank");
             Console.WriteLine("Vänligen logga in");

            string login = "";  // Username login
            string Pin = "";    // User Pin
            int userAcc = 0;    // Taking the usernumber
            int guess = 0;      // account guesses
            bool tryGuess = false;  // To break out of the loop if the correct information
            decimal over; 


                while (tryGuess == false && guess < 3)
                {
                    Console.WriteLine("Enter your username: ");
                    login = Console.ReadLine();
                    Console.WriteLine("Enter your PIN 4 digits: ");
                    Pin = Console.ReadLine();
                    guess++;

                    // Going through the Users Array to se if there is a match to the inputs.
                for (int i = 0; i < Users.GetLength(0); i++)
                {
                    if (login == Users[i, 0] && Pin == Users[i, 1])
                    {
                            userAcc = i; // Taking the userindex of the array
                            tryGuess = true; // break the loop
                    }
                    else if (login == Users[i, 0] && Pin != Users[i, 1])
                    {
                        Console.WriteLine("Your Pin was wrong!");

                    }
                    else if (login != Users[i, 0] && Pin == Users[i, 1])
                    {
                        Console.WriteLine("Your login was wrong");
                    }
                    else if (guess == 3)
                        {
                            ShutDown = false;
                        }
                        
                }
                    
            }
                // 5 If statements for the 5 accounts depending on who logged in
                if (login == Users[0,0]) 
                {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                do
                    {
                        Console.WriteLine("1. Se dina konton och saldo");
                        Console.WriteLine("2. Överföring mellan konton");
                        Console.WriteLine("3. Ta ut Pengar");
                        Console.WriteLine("4. Logga ut");
                        string uChoice = Console.ReadLine();
                        Console.Clear();

                        switch (uChoice)
                        {

                            case "1":
                                ShowAccount(Damir);
                                break;
                            case "2":
                                Transfer2(Damir);
                                break;
                            case "3":
                                Whitdraw2(Users, Damir, userAcc, ref Pin);
                                break;
                            case "4":
                               UsersUse = LogOut();
                                break;
                            default:
                                Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                                break;
                        }
                    } while (UsersUse == false); 
                    UsersUse = false; /*Setting bool back to false becasue the next user will
                    get kicked out of the loop if it remains true*/


                }
                
            if (login == Users[1, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");
                do
                {
                        Console.WriteLine("1. Se dina konton och saldo");
                        Console.WriteLine("2. Överföring mellan konton");
                        Console.WriteLine("3. Ta ut Pengar");
                        Console.WriteLine("4. Logga ut");
                        string uChoice = Console.ReadLine();
                        Console.Clear();

                        switch (uChoice)
                        {

                        case "1":
                                ShowAccount(Banan);
                            break;
                        case "2":
                                Transfer2(Banan);
                            break;
                        case "3":
                            Whitdraw2(Users, Banan, userAcc, ref Pin);
                            break;
                        case "4":
                               UsersUse = LogOut();
                                break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            break;
                    }
                } while (UsersUse == false);
                    UsersUse = false;
                }

            if (login == Users[2, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");
                do
                {
                        Console.WriteLine("1. Se dina konton och saldo");
                        Console.WriteLine("2. Överföring mellan konton");
                        Console.WriteLine("3. Ta ut Pengar");
                        Console.WriteLine("4. Logga ut");
                        string uChoice = Console.ReadLine();
                        Console.Clear();

                        switch (uChoice)
                        {

                        case "1":
                                ShowAccount(Äpple);
                            break;
                        case "2":
                            Transfer2(Äpple);
                            break;
                        case "3":
                            Whitdraw2(Users, Äpple, userAcc, ref Pin);
                            break;
                        case "4":
                                UsersUse = LogOut();
                                break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            break;
                        }
                } while (UsersUse == false);
                    UsersUse = false;

            }

            if (login == Users[3, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");
                do
                {
                        
                        Console.WriteLine("1. Se dina konton och saldo");
                        Console.WriteLine("2. Överföring mellan konton");
                        Console.WriteLine("3. Ta ut Pengar");
                        Console.WriteLine("4. Logga ut");
                        string uChoice = Console.ReadLine();
                        Console.Clear();

                        switch (uChoice)
                        {
                        case "1":
                                ShowAccount(Päron);
                            break;
                        case "2":
                            Transfer2(Päron);
                            break;
                        case "3":
                            Whitdraw2(Users, Päron, userAcc, ref Pin);
                            break;
                        case "4":

                                UsersUse = LogOut();
                                break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            break;
                    }
                } while (UsersUse == false);
                    UsersUse = false;

            }
                // Apelsin 1 account
                
                if (login == Users[4, 0])
            {
                    
                    Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");
                do
                {
                        Console.WriteLine("1. Se dina konton och saldo");
                        Console.WriteLine("2. Överföring mellan konton");
                        Console.WriteLine("3. Ta ut Pengar");
                        Console.WriteLine("4. Logga ut");
                        string uChoice = Console.ReadLine();
                        Console.Clear();

                            switch (uChoice)
                            {

                            case "1":
                                Console.WriteLine("1. Personkonto " + Apelsin[0]);
                                break;
                            case "2":

                            Console.WriteLine("1. Personkonto " + Apelsin[0]);
                            Console.WriteLine("Vill du sätta in pengar: Ja / Nej");
                            string ja = Console.ReadLine();
                            if (ja == "Ja")
                            {
                            Console.Write("Hur mycket vill du sätta in: ");
                            decimal.TryParse(Console.ReadLine(), out decimal ut);
                            if (ut > 0)
                            {
                            Apelsin[0] = Apelsin[0] + ut;
                            Console.WriteLine("Ditt nya saldo är: " + Apelsin[0]);
                            }
                            }
                            
                            Enter();
                            break;
                        case "3":

                            Console.WriteLine("1. Personkonto " + Apelsin[0]);
                            Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Apelsin[0]);
                                decimal.TryParse(Console.ReadLine(), out over);
                            if (over <= Apelsin[0] && over > 0)
                            {
                                Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                Pin = Console.ReadLine();
                                if (Pin == Users[userAcc, 1])
                                {
                                    Apelsin[0] = Apelsin[0] - over;
                                    Console.WriteLine("Summan kvar på kontot är " + Apelsin[0]);
                                    Enter();
                                }
                                else Console.WriteLine("Fel Pin");
                                    Enter();
                            }
                            else Console.WriteLine("Summan stämmer inte överens med kontots saldo");
                                Enter();
                            break;
                            case "4":
                                UsersUse = LogOut();
                                break;
                            default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            break;
                            }
                } while (UsersUse == false);
                    UsersUse = false;
                    
            }
            } while (ShutDown == true);

        }


        private static bool LogOut()
        {
            // Logout and a new user can login
            bool UsersUse;
            Console.WriteLine("Du Loggas ut");
            Thread.Sleep(700);
            Console.Clear();
            UsersUse = true;
            return UsersUse = true;
        }

        private static void Whitdraw2(string[,] Users, decimal[] Accounts, int userAcc, ref string Pin)
        {
            string draw;
            // Depending on the logged in user
            Console.WriteLine("1. Personkonto " + Accounts[0]);
            Console.WriteLine("2. Lönekonto " + Accounts[1]);
            // From which account to whitdraw
            Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
            draw = Console.ReadLine();
            Console.Clear();

            if (draw == "1")
            {
                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Accounts[0]);
                decimal.TryParse(Console.ReadLine(), out decimal ut);
                // If the account has the balance
                if (ut <= Accounts[0] && ut > 0)
                {
                    Console.Write("Bekräfta uttaget genom att slå in din Pin:");
                    Pin = Console.ReadLine();
                    // Confirm the whitdraw with Pin
                    if (Pin == Users[userAcc, 1])
                    {
                        Accounts[0] = Accounts[0] - ut;
                        Console.WriteLine("Summan kvar på kontot är " + Accounts[0]);
                        Enter();
                    }
                    // If wrong Pin back to main menu
                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                    Enter();
                }
                // If wrong amount registered back to menu
                else Console.WriteLine("Summan stämmer inte överens med kontots saldo: " + Accounts[0]);
                Enter();
            }
            else if (draw == "2")
            {
                // Same as before on the second account
                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Accounts[1]);
                decimal.TryParse(Console.ReadLine(), out decimal ut);

                if (ut <= Accounts[1] && ut > 0)
                {
                    Console.Write("Bekräfta uttaget genom att slå in din Pin:");
                    Pin = Console.ReadLine();
                    if (Pin == Users[userAcc, 1])
                    {
                        Accounts[1] = Accounts[1] - ut;
                        Console.WriteLine("Summan kvar på kontot är " + Accounts[1]);
                        Enter();
                    }
                    else Console.WriteLine("Fel Pin:");
                    Enter();
                }
                else Console.WriteLine("Summan stämmer inte överens med kontots saldo: " + Accounts[1]);
                Enter();
            }
            else
            {
                Console.WriteLine("Ogiltigt val");
                Console.WriteLine("Du skickas tillbaka till huvudmenyn");
                Thread.Sleep(500);
            }

            
        }

        private static void Transfer2(decimal[] Accounts)
        {
            // Depending on the logged in user it will be his acount.
            Console.WriteLine("1. Personkonto " + Accounts[0]);
            Console.WriteLine("2. Lönekonto " + Accounts[1]);
            // Checking which account ge wants to transfer from.
            Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
            string Count = Console.ReadLine();
            Console.Clear();

            if (Count == "1")
            {

                Console.WriteLine("1. Personkonto " + Accounts[0]);
                Console.Write("Ange summan du vill föra över:");
                decimal.TryParse(Console.ReadLine(), out decimal over);
                // If there is that amount that the user wrote in the account.
                if (over <= Accounts[0] && over >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Du förde över " + over + "kr till ditt lönekonto");
                    Accounts[0] = Accounts[0] - over;
                    Accounts[1] = Accounts[1] + over;
                    Console.WriteLine("1. Personkonto " + Accounts[0]);
                    Console.WriteLine("2. Lönekonto " + Accounts[1]);
                    Enter();
                }
                else if (over > Accounts[0] || over < 0)
                {
                    // If the amount is wrong sending back to main menu.
                    Console.WriteLine("Summan stämmer inte överens med ditt nuvarande saldo: " + Accounts[0]);
                    Enter();
                }
            }
            else if (Count == "2")
            {
                // Same as before on the second account
                Console.WriteLine("2. Lönekonto " + Accounts[1]);
                Console.Write("Ange summan du vill föra över:");
                decimal.TryParse(Console.ReadLine(), out decimal over);
                if (over <= Accounts[1] && over >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Du förde över " + over + "kr till ditt Personkonto");
                    Accounts[0] = Accounts[0] + over;
                    Accounts[1] = Accounts[1] - over;
                    Console.WriteLine("1) Personkonto " + Accounts[0]);
                    Console.WriteLine("2) Lönekonto " + Accounts[1]);
                    Enter();
                }
                else if (over > Accounts[1] || over < 0)
                {
                    Console.WriteLine("Summan stämmer inte överens med ditt nuvarande saldo: " + Accounts[1]);
                    Enter();
                }
            }
            // If the user presses any other number than the account numbers.
            else
            {
                Console.WriteLine("Ogiltigt val");
                Console.WriteLine("Du skickas tillbaka till huvudmenyn");
                Thread.Sleep(500);
            }
        }

        public static void ShowAccount(decimal[] Accounts)
        {
                Console.WriteLine("1. Personkonto " + Accounts[0]);
                Console.WriteLine("2. Lönekonto " + Accounts[1]);
                Enter();
        }

        private static void Enter()
        {
            bool press = false;

            // Method to press enter, if the user presses any other button he is in the loop.

            do
            {          
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn.");
                string enter = Console.ReadLine();

                if (enter == "")
                {
                    Console.Clear();
                    press = true;
                }
                else
                {
                    Console.Write("");
                }
            } while (press == false);
        }
    }

}
    

