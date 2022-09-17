using System.Reflection.Emit;

namespace SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationType operationType = GetOperationFromUser();

            int number1 = GetNumberFromUser("Podaj pierwsza liczbe: ");
            int number2 = GetNumberFromUser("Podaj druga liczbe: ");

            double result = CalculateResult(number1, number2, operationType);

            Console.WriteLine($"Wynik {operationType} =  {result}");
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



        static OperationType GetOperationFromUser()
        {
            Console.WriteLine("Witaj w kalkulatorze, wybierz oparację kalulatora");
            Console.WriteLine(" 1-Dodawanie \n 2-Odejmowanie \n 3-Mnozenie \n 4-Dzielenie");
            int indeks = Convert.ToInt32(Console.ReadLine());
            OperationType wybranaMetoda = (OperationType)indeks;
            return wybranaMetoda;
        }

        public enum OperationType
        {
            Dodawanie = 1,
            Odejmowanie,
            Mnozenie,
            Dzielenie,
        }

        static double CalculateResult(double number1, double number2, OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Dodawanie:
                    return number1 + number2;
                case OperationType.Odejmowanie:
                    return number1 - number2;

                case OperationType.Mnozenie:
                    return number1 * number2;

                case OperationType.Dzielenie:
                    return number1 / number2;

                default:
                    return 0;

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