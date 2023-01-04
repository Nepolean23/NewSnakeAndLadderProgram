using SnakeAndLadder;
//Player Position
//PlayerPosition.position();

//Player Rolls Dies
//PlayerRollsADies.RollDies();

//Player Checks For Noplay,Ladder,Snake
//PlayerChecksForOption.Option();

//Player reaches Wining position
//PlayerReachesWiningPosition.Winingposition();

//Player reaches ExactPosition
//PlayerExactWiningPosition.ExactWining();

//Counting Number Of DiceRolled
//CountingOfDice.counts();

//Playing NewGame With TwoPlayers
PlayingNewGame player1= new PlayingNewGame();
int a = player1.Dice();

PlayingNewGame player2= new PlayingNewGame();
int b= player2.Dice();

if(a>b)
{
    Console.WriteLine("Player One Wins");
}
else if(b>a)
{
    Console.WriteLine("Player Two Wins");
}