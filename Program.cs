using System;
using System.Threading;

namespace Individuella_projektet
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

            

            Console.WriteLine("Välkommen till Spacebank");

            string login = "";
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


                if (login == Users[0,0]) 
                {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal over;
                string Pin = "";

                do
                {

                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());
                    

                        switch (uChoice)
                        {

                            case 1:
                                {
                                    ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin); // KLLLLLAAAAAAAAAARRRRTTTT
                                }
                                break;
                            case 2:

                                Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
                                int Count = int.Parse(Console.ReadLine()); 
                                Console.Clear();


                                if (Count == 1)
                                {

                                    Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                    Console.WriteLine("Ange summan du vill föra över:");
                                    over = decimal.Parse(Console.ReadLine());
                                    if (over <= Damir[userAcc] && over >= 0)
                                    {
                                        Damir[userAcc] = Damir[userAcc] - over;
                                        Damir[userAcc + 1] = Damir[userAcc + 1] + over;
                                        Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                        Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                        Console.WriteLine("Klicka enter för att komma till menyn");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                else if (Count == 2)
                                {
                                    Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                    Console.WriteLine("Ange summan du vill föra över:");
                                    over = decimal.Parse(Console.ReadLine());
                                    if (over <= Damir[userAcc + 1] && over >= 0)
                                    {

                                        Console.WriteLine("Den nya summan på dina konto är följande:");

                                        Damir[userAcc] = Damir[userAcc] + over;
                                        Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                        Damir[userAcc + 1] = Damir[userAcc + 1] - over;
                                        Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                        Console.WriteLine("Klicka enter för att komma till menyn");
                                        Console.ReadLine();
                                        Console.Clear();

                                    }
                                }
                                else if (Count >= 3)
                            {
                                Console.WriteLine("Ogiltigt val");
                                Console.WriteLine("Klicka Enter för att komma tillbaka till menyn");
                                Console.ReadLine();Console.Clear();
                            }
                                break;
                            case 3:                                                 



                                Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                                Count = int.Parse(Console.ReadLine());
                                Console.Clear();


                                if (Count == 1)
                                {

                                    Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc]);
                                    over = decimal.Parse(Console.ReadLine());
                                    if (over <= Damir[userAcc] && over > 0)
                                    {
                                        Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                        Pin = Console.ReadLine();
                                        if (Pin == Users[userAcc, 1])
                                        {
                                            Damir[userAcc] = Damir[userAcc] - over;

                                            Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc]);
                                            Console.WriteLine("Klicka Enter för att komma till menyn");
                                            Console.ReadLine(); Console.Clear();
                                        }
                                        else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                    }
                                    else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                                }



                                else if (Count == 2) 
                                { 
                                    Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc + 1]);
                                    over = decimal.Parse(Console.ReadLine());

                                if (over <= Damir[userAcc + 1] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Damir[userAcc + 1] = Damir[userAcc + 1] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc + 1]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                                }
                            break;
                        case 4:


                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");
                            

                            break;
                    }
                } while (UsersUse == false);

            }

            if (login == Users[1, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal over;
                string Pin = "";

                do
                {

                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());


                    switch (uChoice)
                    {

                        case 1:
                            {
                                ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin); // KLLLLLAAAAAAAAAARRRRTTTT
                            }
                            break;
                        case 2:

                            Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
                            int Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc] && over >= 0)
                                {
                                    Damir[userAcc] = Damir[userAcc] - over;
                                    Damir[userAcc + 1] = Damir[userAcc + 1] + over;
                                    Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                    Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else if (Count == 2)
                            {
                                Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc + 1] && over >= 0)
                                {

                                    Console.WriteLine("Den nya summan på dina konto är följande:");

                                    Damir[userAcc] = Damir[userAcc] + over;
                                    Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                    Damir[userAcc + 1] = Damir[userAcc + 1] - over;
                                    Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();

                                }
                            }
                            else if (Count >= 3)
                            {
                                Console.WriteLine("Ogiltigt val");
                                Console.WriteLine("Klicka Enter för att komma tillbaka till menyn");
                                Console.ReadLine(); Console.Clear();
                            }
                            break;
                        case 3:                                                  // KLLLLAAAAAARRRRRRRRRRRRRRRRT



                            Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                            Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc]);
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {
                                        Damir[userAcc] = Damir[userAcc] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }



                            else if (Count == 2)
                            {
                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc + 1]);
                                over = decimal.Parse(Console.ReadLine());

                                if (over <= Damir[userAcc + 1] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Damir[userAcc + 1] = Damir[userAcc + 1] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc + 1]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }
                            break;
                        case 4:


                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");


                            break;
                    }
                } while (UsersUse == false);

            }

            if (login == Users[2, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal over;
                string Pin = "";

                do
                {

                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());


                    switch (uChoice)
                    {

                        case 1:
                            {
                                ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin); // KLLLLLAAAAAAAAAARRRRTTTT
                            }
                            break;
                        case 2:

                            Console.WriteLine("1. Personkonto " + Äpple[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Äpple[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
                            int Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("1. Personkonto " + Äpple[userAcc]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Äpple[userAcc] && over >= 0)
                                {
                                    Äpple[userAcc] = Äpple[userAcc] - over;
                                    Äpple[userAcc + 1] = Äpple[userAcc + 1] + over;
                                    Console.WriteLine("1. Personkonto " + Äpple[userAcc]);
                                    Console.WriteLine("2. Lönkonto " + Äpple[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else if (Count == 2)
                            {
                                Console.WriteLine("2. Lönkonto " + Äpple[userAcc + 1]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Äpple[userAcc + 1] && over >= 0)
                                {

                                    Console.WriteLine("Den nya summan på dina konto är följande:");

                                    Äpple[userAcc] = Äpple[userAcc] + over;
                                    Console.WriteLine("1. Personkonto " + Äpple[userAcc]);
                                    Äpple[userAcc + 1] = Äpple[userAcc + 1] - over;
                                    Console.WriteLine("2. Lönekonto " + Äpple[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();

                                }
                            }
                            else if (Count >= 3)
                            {
                                Console.WriteLine("Ogiltigt val");
                                Console.WriteLine("Klicka Enter för att komma tillbaka till menyn");
                                Console.ReadLine(); Console.Clear();
                            }
                            break;
                        case 3:                                                 



                            Console.WriteLine("1. Personkonto " + Äpple[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Äpple[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                            Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Äpple[userAcc]);
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Äpple[userAcc] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {
                                        Äpple[userAcc] = Äpple[userAcc] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Äpple[userAcc]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }



                            else if (Count == 2)
                            {
                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Äpple[userAcc + 1]);
                                over = decimal.Parse(Console.ReadLine());

                                if (over <= Äpple[userAcc + 1] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Äpple[userAcc + 1] = Äpple[userAcc + 1] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Äpple[userAcc + 1]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }
                            break;
                        case 4:


                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");


                            break;
                    }
                } while (UsersUse == false);

            }

            if (login == Users[3, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal over;
                string Pin = "";

                do
                {

                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());


                    switch (uChoice)
                    {

                        case 1:
                            {
                                ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin); // KLLLLLAAAAAAAAAARRRRTTTT
                            }
                            break;
                        case 2:

                            Console.WriteLine("1. Personkonto " + Päron[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Päron[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
                            int Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("1. Personkonto " + Päron[userAcc]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Päron[userAcc] && over >= 0)
                                {
                                    Päron[userAcc] = Päron[userAcc] - over;
                                    Päron[userAcc + 1] = Päron[userAcc + 1] + over;
                                    Console.WriteLine("1. Personkonto " + Päron[userAcc]);
                                    Console.WriteLine("2. Lönkonto " + Päron[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else if (Count == 2)
                            {
                                Console.WriteLine("2. Lönkonto " + Päron[userAcc + 1]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Päron[userAcc + 1] && over >= 0)
                                {

                                    Console.WriteLine("Den nya summan på dina konto är följande:");

                                    Päron[userAcc] = Päron[userAcc] + over;
                                    Console.WriteLine("1. Personkonto " + Päron[userAcc]);
                                    Päron[userAcc + 1] = Päron[userAcc + 1] - over;
                                    Console.WriteLine("2. Lönekonto " + Päron[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();

                                }
                            }
                            else if (Count >= 3)
                            {
                                Console.WriteLine("Ogiltigt val");
                                Console.WriteLine("Klicka Enter för att komma tillbaka till menyn");
                                Console.ReadLine(); Console.Clear();
                            }
                            break;
                        case 3:                                                  // KLLLLAAAAAARRRRRRRRRRRRRRRRT



                            Console.WriteLine("1. Personkonto " + Päron[0]);
                            Console.WriteLine("2. Lönekonto " + Päron[1]);
                            Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                            Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Päron[userAcc]);
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Päron[userAcc] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {
                                        Päron[userAcc] = Päron[userAcc] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Päron[userAcc]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }



                            else if (Count == 2)
                            {
                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Päron[userAcc + 1]);
                                over = decimal.Parse(Console.ReadLine());

                                if (over <= Päron[userAcc + 1] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Päron[userAcc + 1] = Päron[userAcc + 1] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Päron[userAcc + 1]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");

                            }





                            //else if (Users[1, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Banan[userAcc]);
                            //    Console.WriteLine("2. Lönekonto " + Banan[userAcc + 1]);
                            //    Console.WriteLine("3. Sparkonto " + Banan[userAcc + 2]);
                            //    Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 3");
                            //    int Count = int.Parse(Console.ReadLine());
                            //    Console.Clear();
                            //        switch (Count)
                            //        {

                            //            case 1:
                            //                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Banan[userAcc]);
                            //                Achoice = decimal.Parse(Console.ReadLine());
                            //                if (Achoice < Banan[userAcc] && Achoice > 0)
                            //                {
                            //                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //                    Pin = Console.ReadLine();
                            //                    if (Pin == Users[userAcc, 1])
                            //                    {
                            //                        Banan[userAcc] = Banan[userAcc] - Achoice;

                            //                        Console.WriteLine("Summan kvar på kontot är " + Banan[userAcc]);
                            //                        Console.WriteLine("Klicka Enter för att komma till menyn");
                            //                        Console.ReadLine(); Console.Clear();
                            //                    }
                            //                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                            //                }
                            //                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            //                break;

                            //            case 2:

                            //                Count = Count - 1;
                            //                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Banan[userAcc + Count]);
                            //                Achoice = decimal.Parse(Console.ReadLine());
                            //                if (Achoice < Banan[userAcc + Count] && Achoice > 0)
                            //                {
                            //                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //                    Pin = Console.ReadLine();
                            //                    if (Pin == Users[userAcc, 1])
                            //                    {


                            //                        Banan[userAcc + Count] = Banan[userAcc + Count] - Achoice;

                            //                        Console.WriteLine("Summan kvar på kontot är " + Banan[userAcc + Count]);
                            //                        Console.WriteLine("Klicka Enter för att komma till menyn");
                            //                        Console.ReadLine(); Console.Clear();
                            //                    }
                            //                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                            //                }
                            //                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");

                            //                break;



                            //        }
                            //    }
                            //else if (Users[2, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Äpple[0]);
                            //    Console.WriteLine("2. Lönekonto " + Äpple[1]);
                            //    Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                            //    Console.ReadKey();

                            //}
                            //else if (Users[3, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Päron[0]);
                            //    Console.WriteLine("2. Lönekonto " + Päron[1]);
                            //    Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                            //    Console.ReadKey();

                            //}
                            //else if (Users[4, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Apelsin[0]);
                            //    Console.WriteLine("Hur mycket vill ta ut:");
                            //    Achoice = decimal.Parse(Console.ReadLine());
                            //    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //    Pin = Console.ReadLine();
                            //    if (Pin == Users[4, 1])
                            //    {

                            //        Apelsin[0] = Apelsin[0] - Achoice;

                            //        Console.WriteLine("Summan kvar på kontot är " + Apelsin[0]);
                            //    }
                            //    else Console.WriteLine("Fel Pin ");

                            //    Console.WriteLine("tryck Enter för att komma tillbaka till menyn");
                            //    Console.ReadKey();

                            //}


                            break;
                        case 4:


                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");


                            break;
                    }
                } while (UsersUse == false);

            }

            if (login == Users[userAcc, 0])
            {
                Console.WriteLine("välkommen " + login + " Välj mellan följande alternativ:");

                bool UsersUse = false;
                decimal over;
                string Pin = "";

                do
                {

                    Console.WriteLine("1. Se dina konton och saldo");
                    Console.WriteLine("2. Överföring mellan konton");
                    Console.WriteLine("3. Ta ut Pengar");
                    Console.WriteLine("4. Logga ut");
                    int uChoice = int.Parse(Console.ReadLine());


                    switch (uChoice)
                    {

                        case 1:
                            {
                                ShowAccount(login, Users, Damir, Banan, Äpple, Päron, Apelsin); // KLLLLLAAAAAAAAAARRRRTTTT
                            }
                            break;
                        case 2:

                            Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra överföring från: Alt 1 - 2");
                            int Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc] && over >= 0)
                                {
                                    Damir[userAcc] = Damir[userAcc] - over;
                                    Damir[userAcc + 1] = Damir[userAcc + 1] + over;
                                    Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                    Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else if (Count == 2)
                            {
                                Console.WriteLine("2. Lönkonto " + Damir[userAcc + 1]);
                                Console.WriteLine("Ange summan du vill föra över:");
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc + 1] && over >= 0)
                                {

                                    Console.WriteLine("Den nya summan på dina konto är följande:");

                                    Damir[userAcc] = Damir[userAcc] + over;
                                    Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                                    Damir[userAcc + 1] = Damir[userAcc + 1] - over;
                                    Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                                    Console.WriteLine("Klicka enter för att komma till menyn");
                                    Console.ReadLine();
                                    Console.Clear();

                                }
                            }
                            else if (Count >= 3)
                            {
                                Console.WriteLine("Ogiltigt val");
                                Console.WriteLine("Klicka Enter för att komma tillbaka till menyn");
                                Console.ReadLine(); Console.Clear();
                            }
                            break;
                        case 3:                                                  // KLLLLAAAAAARRRRRRRRRRRRRRRRT



                            Console.WriteLine("1. Personkonto " + Damir[userAcc]);
                            Console.WriteLine("2. Lönekonto " + Damir[userAcc + 1]);
                            Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 2");
                            Count = int.Parse(Console.ReadLine());
                            Console.Clear();


                            if (Count == 1)
                            {

                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc]);
                                over = decimal.Parse(Console.ReadLine());
                                if (over <= Damir[userAcc] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {
                                        Damir[userAcc] = Damir[userAcc] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            }



                            else if (Count == 2)
                            {
                                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Damir[userAcc + 1]);
                                over = decimal.Parse(Console.ReadLine());

                                if (over <= Damir[userAcc + 1] && over > 0)
                                {
                                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                                    Pin = Console.ReadLine();
                                    if (Pin == Users[userAcc, 1])
                                    {


                                        Damir[userAcc + 1] = Damir[userAcc + 1] - over;

                                        Console.WriteLine("Summan kvar på kontot är " + Damir[userAcc + 1]);
                                        Console.WriteLine("Klicka Enter för att komma till menyn");
                                        Console.ReadLine(); Console.Clear();
                                    }
                                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                                }
                                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");

                            }





                            //else if (Users[1, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Banan[userAcc]);
                            //    Console.WriteLine("2. Lönekonto " + Banan[userAcc + 1]);
                            //    Console.WriteLine("3. Sparkonto " + Banan[userAcc + 2]);
                            //    Console.WriteLine("Vilket konto vill du göra uttag från: Alt 1 - 3");
                            //    int Count = int.Parse(Console.ReadLine());
                            //    Console.Clear();
                            //        switch (Count)
                            //        {

                            //            case 1:
                            //                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Banan[userAcc]);
                            //                Achoice = decimal.Parse(Console.ReadLine());
                            //                if (Achoice < Banan[userAcc] && Achoice > 0)
                            //                {
                            //                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //                    Pin = Console.ReadLine();
                            //                    if (Pin == Users[userAcc, 1])
                            //                    {
                            //                        Banan[userAcc] = Banan[userAcc] - Achoice;

                            //                        Console.WriteLine("Summan kvar på kontot är " + Banan[userAcc]);
                            //                        Console.WriteLine("Klicka Enter för att komma till menyn");
                            //                        Console.ReadLine(); Console.Clear();
                            //                    }
                            //                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                            //                }
                            //                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");
                            //                break;

                            //            case 2:

                            //                Count = Count - 1;
                            //                Console.WriteLine("Hur mycket vill du ta ut: Saldo " + Banan[userAcc + Count]);
                            //                Achoice = decimal.Parse(Console.ReadLine());
                            //                if (Achoice < Banan[userAcc + Count] && Achoice > 0)
                            //                {
                            //                    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //                    Pin = Console.ReadLine();
                            //                    if (Pin == Users[userAcc, 1])
                            //                    {


                            //                        Banan[userAcc + Count] = Banan[userAcc + Count] - Achoice;

                            //                        Console.WriteLine("Summan kvar på kontot är " + Banan[userAcc + Count]);
                            //                        Console.WriteLine("Klicka Enter för att komma till menyn");
                            //                        Console.ReadLine(); Console.Clear();
                            //                    }
                            //                    else Console.WriteLine("Fel Pin du skickas tillbaka till menyn ");
                            //                }
                            //                else Console.WriteLine("Summan stämmer inte överens med kontots saldo du skickas tillbaka till menyn ");

                            //                break;



                            //        }
                            //    }
                            //else if (Users[2, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Äpple[0]);
                            //    Console.WriteLine("2. Lönekonto " + Äpple[1]);
                            //    Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                            //    Console.ReadKey();

                            //}
                            //else if (Users[3, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Päron[0]);
                            //    Console.WriteLine("2. Lönekonto " + Päron[1]);
                            //    Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                            //    Console.ReadKey();

                            //}
                            //else if (Users[4, 0] == login)
                            //{
                            //    Console.WriteLine("1. Personkonto " + Apelsin[0]);
                            //    Console.WriteLine("Hur mycket vill ta ut:");
                            //    Achoice = decimal.Parse(Console.ReadLine());
                            //    Console.WriteLine("Bekräfta uttaget genom att slå in din Pin:");
                            //    Pin = Console.ReadLine();
                            //    if (Pin == Users[4, 1])
                            //    {

                            //        Apelsin[0] = Apelsin[0] - Achoice;

                            //        Console.WriteLine("Summan kvar på kontot är " + Apelsin[0]);
                            //    }
                            //    else Console.WriteLine("Fel Pin ");

                            //    Console.WriteLine("tryck Enter för att komma tillbaka till menyn");
                            //    Console.ReadKey();

                            //}


                            break;
                        case 4:


                            Console.WriteLine("välkommen tillbaka =)");
                            UsersUse = true;
                            break;
                        default:
                            Console.WriteLine("ogiltigt val! Välj mellan 1-4");


                            break;
                    }
                } while (UsersUse == false);

            }
            Console.WriteLine("hejdååååååååå");

           

             










        }

         public static void ShowAccount(string login, string[,] Users, decimal[] Damir, decimal[] Banan, decimal[] Äpple, decimal[] Päron, decimal[] Apelsin)
        {
            if (Users[0, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Damir[0]);
                Console.WriteLine("2. Lönkonto " + Damir[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Users[1, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Banan[0]);
                Console.WriteLine("2. Lönkonto " + Banan[1]);
                Console.WriteLine("3. Sparkonto " + Banan[2]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Users[2, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Äpple[0]);
                Console.WriteLine("2. Lönkonto " + Äpple[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
                Console.Clear();

            }
            else if (Users[3, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Päron[0]);
                Console.WriteLine("2. Lönkonto " + Päron[1]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
                Console.Clear();

            }
            else if (Users[4, 0] == login)
            {
                Console.WriteLine("1. Personkonto " + Apelsin[0]);
                Console.WriteLine("Klicka Enter för att komma till huvudmenyn");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }

}
    

