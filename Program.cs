using DiceRoll.Game;

var random = new Random(); // generate the seed
var dice = new Dice(random);
var game = new GuessingGame(dice);

var gameResult = game.Play();
GuessingGame.PrintResult(gameResult);
