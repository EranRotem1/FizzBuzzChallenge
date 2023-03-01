namespace FizzBuzz
{
    internal class Program
    {
        public static void FizzBuzz(int num)
        {
            for (int i = 1; i <= num; i++) 
            {
                if (i % 5 == 0 && i % 3 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else Console.WriteLine(i.ToString()) ;
            }
        }
        static void Main(string[] args)
        {
            FizzBuzz(15);
        }
    }
}