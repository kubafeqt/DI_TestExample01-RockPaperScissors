using System.Xml.Serialization;
using static DI_TestExample01.GameManager;

namespace DI_TestExample01.Tests
{
   public class RPSTests
   {
      [Theory]
      [InlineData(Choice.Rock, Choice.Scissors, RoundResult.Player1Win)]
      [InlineData(Choice.Paper, Choice.Rock, RoundResult.Player1Win)]
      [InlineData(Choice.Scissors, Choice.Paper, RoundResult.Player1Win)]

      [InlineData(Choice.Scissors, Choice.Rock, RoundResult.Player2Win)]
      [InlineData(Choice.Rock, Choice.Paper, RoundResult.Player2Win)]
      [InlineData(Choice.Paper, Choice.Scissors, RoundResult.Player2Win)]

      [InlineData(Choice.Rock, Choice.Rock, RoundResult.Draw)]
      [InlineData(Choice.Paper, Choice.Paper, RoundResult.Draw)]
      [InlineData(Choice.Scissors, Choice.Scissors, RoundResult.Draw)]
      public void WinPossibilities(Choice choice1, Choice choice2, RoundResult result)
      {
         GameManager gm = new GameManager(new ForcedPlayer(choice1), new ForcedPlayer(choice2));
         Assert.Equal(result, gm.PlayRound());
      }
   }
}