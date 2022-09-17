namespace SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            string? firstNumber = Console.ReadLine();

            int number1 = 0;
            if (int.TryParse(firstNumber, out number1) == false)
            {
                Console.WriteLine("Pierwsza wprowadzona wartość nie jest liczbą");
                return;
            }

            Console.WriteLine("Podaj drugą liczbę:");
            string? secondNumber = Console.ReadLine();

            int number2 = 0;
            if (int.TryParse(secondNumber, out number2) == false)
            {
                Console.WriteLine("Druga wprowadzona wartość nie jest liczbą");
                return;
            }

            int result = number1 * number2;

            Console.WriteLine($"Wynik mnożenia {number1} * {number2} = {result}");
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