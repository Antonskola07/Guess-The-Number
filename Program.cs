// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Random random = new Random();
int secretNum = random.Next(1, 100);
int guessCount = 0;
while(true) {
    int guess;
    guessCount++;
    try {
        Console.Write("Skriv ett nummer: ");
        guess = int.Parse(Console.ReadLine()!);
    } catch {
        Console.WriteLine("Ogiltigt!");
        continue;
    }
    if(guess == secretNum) break;
    if(guess > secretNum) Console.WriteLine("Lägre");
    else Console.WriteLine("Högre");
}

Console.WriteLine($"Rätt gissning! Du tog {guessCount} gissningar på dig.");