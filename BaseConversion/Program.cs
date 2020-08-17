using System;

namespace BaseConversion
{
    class Program
    {
        public static void toBinary(int n)
        {
            if (n == 0)
                return;
            toBinary(n / 2);
            Console.Write(n%2);
        }
        
        public static void convertBase(int n,int b)
        {
            if (n == 0)
                return;
            convertBase(n / b, b);

            int remainder = n % b;
            if (remainder < 10)
                Console.Write(remainder);
            else
                Console.Write((char) (remainder-10 + 'A'));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive decimal number: "); ;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Binary Form: "); toBinary(x);
            Console.WriteLine("");
            Console.Write("Binary Form: "); convertBase(x, 2);
            Console.WriteLine("");
            Console.Write("Octal Form: "); convertBase(x, 8);
            Console.WriteLine("");
            Console.Write("Hexadecimal Form: "); convertBase(x, 16);
            Console.WriteLine("");
        }
    }
}
