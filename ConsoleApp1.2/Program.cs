namespace ConsoleApp1._2;
internal class Program
{
    static void Main(string[] args)
    {

        while (true)
        {

            Console.Write("Enter an integer (zero to close): ");
            string answer = Console.ReadLine();

            int aNumber = Convert.ToInt32(answer);

            if (aNumber == 0)
            {
                break;
            }

                if (aNumber % 2 == 0)
                {
                    Console.WriteLine($"{aNumber} is even");
                }
                else
                {
                    Console.WriteLine($"{aNumber} is odd.");
                }
            }
            Console.WriteLine("Done...");
        }
    }


