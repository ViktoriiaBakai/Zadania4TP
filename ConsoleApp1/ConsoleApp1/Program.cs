Random random = new Random();
int[] numbers = new int[6];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 50);
}


Console.WriteLine("Wybierz liczby od 1 do 49!");
Console.WriteLine("wybierz 1 liczbę: ");
int liczba1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wybierz 2 liczbę: ");
int liczba2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wybierz 3 liczbę: ");
int liczba3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wybierz 4 liczbę: ");
int liczba4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wybierz 5 liczbę: ");
int liczba5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("wybierz 6 liczbę: ");
int liczba6 = Convert.ToInt32(Console.ReadLine());


int[] userNumbers = {liczba1,liczba2,liczba3,liczba4, liczba5,liczba6};

Console.WriteLine( "Twoje liczby: " + string.Join(",", userNumbers));
Console.WriteLine( "Liczby wylosowane: " + string.Join(",", numbers));

var accurancy = userNumbers.Intersect(numbers);
Console.WriteLine( "Trafione liczby: " + string.Join(",", accurancy));
Console.WriteLine( "Liczba trafień: " + accurancy.Count());