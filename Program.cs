using System;

namespace Individuella_projektet
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "";

            Console.WriteLine("Välkommen till Spacebank");




            // Array of Users
            string[,] Users = new string[5, 2];
            {

                Users[0, 0] = "Damir"; Users[0, 1] = "1234";
                Users[1, 0] = "Banan"; Users[1, 1] = "2345";
                Users[2, 0] = "Äpple"; Users[2, 1] = "3456";
                Users[3, 0] = "Päron"; Users[3, 1] = "4567";
                Users[4, 0] = "Apelsin"; Users[4, 1] = "5678";

            };

            // Array of Accounts

            decimal[] Damir = { 100.50M, 50, };
            decimal[] Banan = { 323.99M, 549.90M, 678.99M, };
            decimal[] Äpple = { 8199, 2999, };
            decimal[] Päron = { 345.78M, 66 };
            decimal[] Apelsin = { 99.34M };



           
          

            int userAcc = 0;
            int guess = 0;
            bool tryGuess = false;


            


            while (tryGuess == false && guess < 3)
            {
                    Console.WriteLine("Enter your username: ");
                    login = Console.ReadLine();
                    Console.WriteLine("Enter your PIN 4 digits: ");
                    string Pin = Console.ReadLine();
                    guess++;

                for (int i = 0; i < Users.GetLength(0); i++)
                {
                    if (login == Users[i, 0] && Pin == Users[i, 1])
                    {
                            userAcc = i;
                            tryGuess = true;
                    }
                    else if (login == Users[i, 0] && Pin != Users[i, 1])
                    {
                        Console.WriteLine("Your Pin was wrong!");

                    }
                    else if (login != Users[i, 0] && Pin == Users[i, 1])
                    {
                        Console.WriteLine("Your login was wrong");

                    }
                        
                        
                }
                    
            }


            try
            {

           

                if (login == Users[userAcc,0]) 
                {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal Achoice;
                string Pin = "";

                do
                {



                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (uChoice)
                    {



                        case 1:
                            {
                                ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin);
                            }
                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                        case 3:
                            if (Users[0, 0] == login)
                            {

                                

                                Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                                int Count = int.Parse(Console.ReadLine());
                                Console.Clear();

                                switch (Count)
                                {
                                    case 1:
                                        Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc]);
                                         Achoice = decimal.Parse(Console.ReadLine());
                                if (Achoice < Damir[userAcc] && Achoice > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Damir[userAcc] = Damir[userAcc] - Achoice;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc]);
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                                    

                                        break;
                                    case 2:

                                        Count = Count - 1;
                                        Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc + Count]);
                                        Achoice = decimal.Parse(Console.ReadLine());
                                        if (Achoice < Damir[userAcc + Count] && Achoice > 0)
                                        {
                                            Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                            Pin = Console.ReadLine();
                                            if (Pin == Users[userAcc, 1])
                                            {


                                                Damir[userAcc + Count] = Damir[userAcc + Count] - Achoice;

                                                Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc + Count]);
                                            }
                                            else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                        }
                                        else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");

                                        break;



                                }
                             }
                            else if (Users[1, 0] == login)
                            {
                                Console.WriteLine("1. Personkonto " + Banan[0]);
                                Console.WriteLine("2. Lönekonto " + Banan[1]);
                                Console.WriteLine("3. Sparkonto " + Banan[2]);
                                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                                Console.ReadKey();
                            }
                            else if (Users[2, 0] == login)
                            {
                                Console.WriteLine("1. Personkonto " + Äpple[0]);
                                Console.WriteLine("2. Lönekonto " + Äpple[1]);
                                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                                Console.ReadKey();

                            }
                            else if (Users[3, 0] == login)
                            {
                                Console.WriteLine("1. Personkonto " + Päron[0]);
                                Console.WriteLine("2. Lönekonto " + Päron[1]);
                                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                                Console.ReadKey();

                            }
                            else if (Users[4, 0] == login)
                            {
                                Console.WriteLine("1. Personkonto " + Apelsin[0]);
                                Console.WriteLine("Hur mycket vill ta ut:");
                                Achoice = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                Pin = Console.ReadLine();
                                if (Pin == Users[4, 1])
                                {

                                    Apelsin[0] = Apelsin[0] - Achoice;

                                    Console.WriteLine("Summan kvar på kontot är " + Apelsin[0]);
                                }
                                else Console.WriteLine("Fel Pin ");

                                Console.WriteLine("tryck Enter för att komma tillbaka till menyn");
                                Console.ReadKey();

                            }

                           
                            break;
                        case 4:
                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            Console.WriteLine("");
                            break;
                    }
                } while (UsersUse == false);

            }
                
            
            



            Console.WriteLine("hejdååååååååå");

            }
            catch (Exception)
            {

                Console.WriteLine("Följ instruktionerna så kraschar inte programmet");
            }











        }

         public static void ShowAccount(string login, string[,] Users, decimal[] Damir, decimal[] Banan, decimal[] Äpple, decimal[] Päron, decimal[] Apelsin)
        {
            if (Users[0, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Damir[0]);
                Console.WriteLine("2. Lönekonto " + Damir[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
            }
            else if (Users[1, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Banan[0]);
                Console.WriteLine("2. Lönekonto " + Banan[1]);
                Console.WriteLine("3. Sparkonto " + Banan[2]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
            }
            else if (Users[2, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Äpple[0]);
                Console.WriteLine("2. Lönekonto " + Äpple[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();

            }
            else if (Users[3, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Päron[0]);
                Console.WriteLine("2. Lönekonto " + Päron[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();

            }
            else if (Users[4, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Apelsin[0]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();

            }
        }
    }

}
    

