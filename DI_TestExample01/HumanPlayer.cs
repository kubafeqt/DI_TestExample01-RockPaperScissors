using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DI_TestExample01.GameManager;

namespace DI_TestExample01
{
   public class HumanPlayer : IPlayer
   {
      public Choice GetChoice()
      {
         Choice p1; //Player 1 (Human)
         do
         {
            Console.Write("Enter Choice: (R)ock, (P)aper or (S)cissors: ");
            string input = Console.ReadLine().ToUpper();
            if (input == "R")
            {
               p1 = Choice.Rock;
               break;
            }
            else if (input == "P")
            {
               p1 = Choice.Paper;
               break;
            }
            else if (input == "S")
            {
               p1 = Choice.Scissors;
               break;
            }
            else
            {
               Console.WriteLine("Invalid choice, try again!");
            }
         }
         while (true);
         return p1;
      }
   }
}
