namespace DiceRoll.UserInteraction;

public static class ConsoleReader {
  public static int ReadInput(string message) {
    bool isValid;
    int number;

    do {
      Console.WriteLine(message);
      isValid = int.TryParse(Console.ReadLine(), out number);
    } while (!isValid && number > 0);

    return number;
  }

}
