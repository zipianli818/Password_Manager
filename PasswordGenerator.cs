using System;
using System.Text;

/*class RandomNumber
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int num = random.Next();
        RandomNumberGenerator generator = new RandomNumberGenerator();

        int randomLimit = random.Next(100); // Generate a single random number below 100
        Console.WriteLine($"Random character: {randomLimit}");

        int randomRange = generator.RandomNumber(100, 500); // Generate a random number within the range [100, 500]
        Console.WriteLine($"Random character: {randomRange}");

        char randomChar = generator.RandomCharacter(); //Generate a random character
        Console.WriteLine($"Random character: {randomChar}");

        string pass = generator.RandomPassword();
        Console.WriteLine($"Your Random Password is: {pass}");
    }
}*/

public class RandomNumberGenerator
{
    private Random random = new Random();

    // Generate random number between a specified range
    public int RandomNumber(int min, int max)
    {
        return random.Next(min, max);
    }

    // Generate random string of a specific size and case
    public string RandomString(int size, bool lowerCase)
    {
        StringBuilder builder = new StringBuilder();
        char cha;
        for (int i = 0; i < size; i++)
        {
            cha = Convert.ToChar(random.Next(26) + 'A');
            builder.Append(cha);
        }
        if (lowerCase)
            return builder.ToString().ToLower();
        return builder.ToString();
    }

    // Generate random character from a predefined pool
    public char RandomCharacter()
    {
        const string poolChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        int index = random.Next(poolChars.Length);
        return poolChars[index];
    }

    // Generate a random password of a given length
    public string RandomPassword()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(RandomString(4, true));
        builder.Append(random.Next(1000, 9999));
        builder.Append(RandomCharacter());
        builder.Append(RandomString(1, false));
        return builder.ToString();
    }
}
