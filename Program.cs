Random flip = new();
int flipResult = flip.Next(0, 2);
 Console.WriteLine(flipResult == 0 ? "heads" : "tails");