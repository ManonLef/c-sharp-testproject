////////////////////////////////////////////////////////
/// Challenge: Improve renewal rate of subscriptions ///
////////////////////////////////////////////////////////

// link: https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-challenge

// Rule 1: Your code should only display one message.
// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
//    Your subscription will expire soon. Renew now!
// Rule 3: If the user's subscription will expire in five days or less, display the messages:
//    Your subscription expires in _ days.
//    Renew now and save 10%!
// Rule 4: If the user's subscription will expire in one day, display the messages:
//    Your subscription expires within a day!
//    Renew now and save 20%!
// Rule 5: If the user's subscription has expired, display the message:
//    Your subscription has expired.
// Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
  Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
  Console.WriteLine("Your subscription expires within a day!");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
  discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
  Console.WriteLine($"Renew now and save {discountPercentage}%.");
}