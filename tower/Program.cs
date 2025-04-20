using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Class_Game_Project
{
    internal class Program
    {
        static Player player = new Player();

        static Monster monster = new Monster(30);
        //static Monster monster1 = new Monster(12);
        //static Monster monster2 = new Monster(12);

        static int floors = 5;
        static int playerFloor = 0;
        static int monsterFloor = 0;
     


        // Monster movement

        static bool moveMonsterUp()
        {
            if (monsterFloor + 1 >= floors)
            {
                return false;
            }
            else
            {
                monsterFloor = monsterFloor + 1;
                Console.WriteLine("Patient Zero has moved up a floor.");
            }
            return true;
        }

        static bool moveMonsterDown()
        {
            if (monsterFloor - 1 < 0)
            {
                return false;
            }
            else
            {
                monsterFloor = monsterFloor - 1;
                Console.WriteLine("Patient Zero has moved down a floor.");

            }
            return true;
        }

        // Player movement

        static bool movePlayerUp()
        {
            if (playerFloor + 1 >= floors)
            {
                return false;

            }
            else
            {
                playerFloor = playerFloor + 1;
                Console.WriteLine("Survivor has moved up a floor.");

            }
            return true;
        }

        static bool movePlayerDown()
        {
            if (playerFloor - 1 < 0)
            {
                return false;
            }
            else
            {
                playerFloor = playerFloor - 1;
                Console.WriteLine("Survivor has moved down a floor.");

            }
            return true;
        }

    












        static void Main(string[] args)
        {

            Console.WriteLine("Contagion!");
            Console.WriteLine("");
            Console.WriteLine("To transition floors use u/up - d/down");
            Console.WriteLine("");
            Console.WriteLine("When encountering Patient Zero on Survivors floor, use a/attack - h/heal - e/ evade");
            Console.WriteLine("");
            // Player movement control

            while (true)
            {

                string input = Console.ReadLine();

                switch (input)
                {
                    case "u":
                    case "up":
                        movePlayerUp();
                        break;

                    case "d":
                    case "down":
                        movePlayerDown();
                        break;

                    case "q":
                    case "quit":
                        return;

                    default:
                        Console.WriteLine("unknown command");

                        break;

                }

                static bool playerAttack()
                {
                    if (playerFloor == monsterFloor)
                    {


                    }
                    return true;

                }


                // Random Monster movement between floors

                Random rng = new Random();

                    int monsterChoice = rng.Next(10);


                    if (monsterChoice <= 2)

                    {
                        moveMonsterUp();

                    }

                    else if (monsterChoice <= 4)

                    {
                        moveMonsterDown();

                    }

                    else if (monsterFloor == playerFloor)
                    {

                        Console.WriteLine("Patient Zero is on Survivors floor.");


                        // Player / Monster decides movement or action 

                        string playerattack = Console.ReadLine();

                        monster.health = monster.health - 1;
                        Console.WriteLine("Survivor uses knife to stab Patient Zero for 5 damage");
                        player.health = player.health - 1;
                        Console.WriteLine("Patient Zero claws Survivor for 3 dmage");




                    }

             }

       



         }

     }
 }



    








