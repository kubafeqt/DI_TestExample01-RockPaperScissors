using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DI_TestExample01.GameManager;

namespace DI_TestExample01
{
   public interface IPlayer
   {
      Choice GetChoice();
   }
}
