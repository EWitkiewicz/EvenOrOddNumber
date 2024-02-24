namespace Praca_Domowa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbe aby sprawdzic czy jest przysta czy nieparzysta:");
                var number = GetNumber();
                var result = EvenOrOdd(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
          
        }
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(),out int number))
                {
                    Console.WriteLine("Podales nieprawidlowe dane");
                    continue;
                }
                return number;
            }
        }

        private static int EvenOrOdd(int number)
        {
            if (number%2==0)
            {
                Console.WriteLine("Twoja liczba jest przysta");
                return 0;
                
            }
            else
            {
                Console.WriteLine("Twoja liczba jest nieparzysta");
                return 0;
            }
        }

    }
}
