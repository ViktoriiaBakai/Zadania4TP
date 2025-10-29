using System.ComponentModel.Design;

Random random = new Random();
int number = random.Next(1, 101);

int attempts = 0;   

Console.WriteLine(" Wpisz wylosowaną liczbę: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

attempts++;

while (userNumber != number)
{

    if (userNumber < number)
    {
        Console.WriteLine("Twoja liczba jest zbyt mała, spróbuj ją powiększyć");
    }
    else if (userNumber > number)
    {
        Console.WriteLine("Twoja liczba jest zbyt duża, spróbuj ją pomniejszyć");
    }

    userNumber = Convert.ToInt32(Console.ReadLine());
    attempts++;
}
Console.WriteLine("Gratulacje! Zgadłeś liczbę");

Console.WriteLine("Ilość twoich prób:" +  attempts);
