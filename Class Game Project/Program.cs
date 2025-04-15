using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Net.Security;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace Class_Game_Project
{
    internal class Program
    {
        static Player player = new Player();

        static Monster monster = new Monster(20);
        static Monster monster1 = new Monster(12);
        static Monster monster2 = new Monster(12);

        static int monsterFloor = 2;
        static int numberOfFloors = 3;

        static bool moveMonsterUp()
        {
            if (monsterFloor + 1 >= numberOfFloors)
            {
                return false;
            }
            else
            {
                monsterFloor = monsterFloor + 1;
            }
            return true;
        }

        static bool moveMonsterDown()
        {
            if (monsterFloor - 1 < 1)
            {
                return false;
            }
            else
            {
                monsterFloor = monsterFloor - 1;
            }
            return true;
        }





        static void Main(string[] args)
        {

            Console.WriteLine("Contagion!");
            
            

            string input = Console.ReadLine();

            switch (Console.ReadLine() .on input

            
                case "u":
                    return moveMonsterDown();

                case "d":
                    return moveMonsterUp();

                default:
                    Console.WriteLine("unknown command");

                    break;

                Random rng = new Random();  

                int monsterChoice = rng.Next(10);

                {
                    if (monsterChoice <=2);

                        moveMonsterDown monster up;


                    else if (monsterChoice <= 4);

                        moveMonsterDown monster down;


                    else

                        do nothing;
                
                }







                }












            } 
    } 
}
































