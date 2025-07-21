using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DI_TestExample01.GameManager;

namespace DI_TestExample01.Tests
{
   public class ForcedPlayer : IPlayer
   {
      private Choice _choice;
      public ForcedPlayer(Choice choice)
      {
         _choice = choice;
      }
      public Choice GetChoice()
      {
         return _choice; // Return the forced choice
      }
   }
}
