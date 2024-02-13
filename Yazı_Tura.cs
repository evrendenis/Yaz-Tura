using system;
Random coin = new Random();
int flip = coin.Next(0, 4);
Console.WriteLine("You have %25 chance");
Console.WriteLine((flip == 0) ? "Yes" : (flip == 1) ? "No" : "Maybe");
Console.ReadKey();

