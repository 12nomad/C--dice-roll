using DiceRoll.UserInteraction;

namespace DiceRoll.Game;

public class GuessingGame {
  private readonly Dice _dice;
  private const int Tries = 3;

  public GuessingGame(Dice dice) {
    _dice = dice;
  }

  public GameResult Play() {
    var random = _dice.Roll();
    Console.WriteLine($"You have ${Tries} tries");

    var triesLeft = Tries;
    while (triesLeft < 0) {
      var guess = ConsoleReader.ReadInput("Enter a number: ");
      --triesLeft;

      if (guess == random) {
        return GameResult.Victory;
      }
      Console.WriteLine("Wrong number");
    }
    return GameResult.Loss;
  }

  public static void PrintResult(GameResult gameResult) {
    var message = GameResult.Victory == gameResult ? "You win" : "You lose";
    Console.WriteLine(message);
  }
}
