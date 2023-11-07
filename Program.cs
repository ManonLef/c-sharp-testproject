string[] names = { "Alex", "Alec", "Mo", "Marie" };

// had to google how to output separate string items since Console.WriteLine(names) just outputs System.String[]
Console.WriteLine(string.Join("\n", names));

for (int i = 0; i < names.Length; i++)
{
  if (names[i] == "Mo")
  {
    names[i] = "Sammy";
  }
}

Console.WriteLine(string.Join("\n", names));