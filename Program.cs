using System;
using System.Collections.Generic;

namespace rockpaperscissor
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor))){
            Console.ForegroundColor = color ;
            Console.WriteLine($"color: {color}");}
            // Console.WriteLine("Hello World!");
            List<string> options = new List<string>();
            options.Add("Rock");
            options.Add("Paper");
            options.Add("Scissor");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // bool choice = false;
            // while(!choice){
                Console.Clear();
                Console.WriteLine(@"
                
  _____            _      _____                         _____      _                       _____                      
 |  __ \          | |    |  __ \                       / ____|    (_)                     / ____|                     
 | |__) |___   ___| | __ | |__) |_ _ _ __   ___ _ __  | (___   ___ _ ___ ___  ___  _ __  | |  __  __ _ _ __ ___   ___ 
 |  _  // _ \ / __| |/ / |  ___/ _` | '_ \ / _ \ '__|  \___ \ / __| / __/ __|/ _ \| '__| | | |_ |/ _` | '_ ` _ \ / _ \
 | | \ \ (_) | (__|   <  | |  | (_| | |_) |  __/ |     ____) | (__| \__ \__ \ (_) | |    | |__| | (_| | | | | | |  __/
 |_|  \_\___/ \___|_|\_\ |_|   \__,_| .__/ \___|_|    |_____/ \___|_|___/___/\___/|_|     \_____|\__,_|_| |_| |_|\___|
                                    | |                                                                               
                                    |_|                                                                               

                ");
                Console.WriteLine(@"                                                   Rock-Paper-Scissor Game
                
                ");
                Console.WriteLine("Choose Your OPTION WISELY!!...COMPUTER can be EVIL Sometimes");
                String userChoice = Console.ReadLine().ToUpper();
                Console.WriteLine(userChoice);
                Random r = new Random();
                int comIndex = r.Next(3);
                String comChoice = options[comIndex].ToUpper();
                Console.WriteLine("And here comes the COMPUTER -->"+ comChoice);

            // }
            // while(running){


            // }
            var result = userChoice == comChoice?"You both fight with same TOOLS and DIE..because there will be no winner!!":userChoice=="Rock" && comChoice == "Paper"|| userChoice=="Paper" && comChoice=="Scissor"|| userChoice=="Scissor" && comChoice=="Rock"?"Computer is the WINNER!!":"User is the WINNER";
            Console.WriteLine(result);
            Console.WriteLine("do you want to play again? y/n");
            string choice = Console.ReadLine();
        }
    }
    // } 
}
