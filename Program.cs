namespace SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = GetNumberFromUser("Podaj pierwsza liczbe: ");
            int number2 = GetNumberFromUser("Podaj druga liczbe: ");
        }
        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            string? inputValue = Console.ReadLine();

            int number = 0;
            if (int.TryParse(inputValue, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Wprowadzona wartość nie jest liczbą");
                return GetNumberFromUser(message);
            }
        }
    }
}

/*
TO-DO:
- Mateusz: użytkownik wybiera rodzaj działania z puli: 1. dodawanie, 2. odejmowanie, 3. mnożenie, 4. dzielenie
- Filip: refaktoryzacja, zasada DRY: opakowanie pobrania liczby od użytkownika w metodę


ZREALIZOWANE
Kalkulator wykonujący jedno działanie:
- Filip: dodawanie
- Mateusz: odejmowanie
- Agnieszka: mnożenie

- aplikacji konsolowej - OK
- pobranie od użytkownika dwóch liczb - OK

- zwraca wynik działania (sformatowany, z napisem 'Wynik dodawania to ...'
 */