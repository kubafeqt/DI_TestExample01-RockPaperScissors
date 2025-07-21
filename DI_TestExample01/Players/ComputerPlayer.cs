using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DI_TestExample01.GameManager;

namespace DI_TestExample01
{
   public class ComputerPlayer : IPlayer
   {
      private Random _rng = new Random();

      public Choice GetChoice()
      {
         Choice p2 = (Choice)_rng.Next(0, 3); //Player 2 (computer)
         //Console.WriteLine($"Player 2 picked {p2}");
         return p2;
      }
   }
}
