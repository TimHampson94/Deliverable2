#region --variables--

string name = "";
string participate = string.Empty;
int score = 0;
int looping = 0;
int cointoss = 0;
string userinput = string.Empty;
int HeadsorTails = 0;
#endregion --variables--


Console.WriteLine("Welcome to the COIN FLIP challenge!");
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Do you want to do the COIN FLIP challenge?");
participate = Console.ReadLine();
if (participate.ToLower().Trim() == "yes")
{
  while (looping < 5)
  {
    Random random = new Random();
    cointoss = random.Next(0, 2);
    Console.WriteLine("Heads or Tails?");
    userinput = Console.ReadLine();

    if (userinput.ToLower().Trim() == "heads")
      HeadsorTails = 0;
    else if (userinput.ToLower().Trim() == "tails")
      HeadsorTails = 1;

    if (HeadsorTails == cointoss)
    {
      score++;
      Console.WriteLine("Correct!");
    }
    else 
      Console.WriteLine("Wrong!");
    looping++;

  }
  Console.WriteLine($"Game Over. Your score is {score}");
}
else if (participate.ToLower().Trim() == "no")
{
  Console.WriteLine($"You are a coward {name}.");
}
