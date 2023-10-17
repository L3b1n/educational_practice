using System;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("  Hello, world! ");
        }

        public static void SayHelloUser(string userName)
        {
            Console.WriteLine($"  Hello, {userName} !");
        }

        public static void PrintFace()
        {                                             /// Print this face.
            Console.WriteLine(" +\"\"\"\"\"+");      ///   +"""""+
            Console.WriteLine("(| o o |)");          ///  (| o o |)
            Console.WriteLine(" |  ^  |");           ///   |  ^  |
            Console.WriteLine(" | '-' |");           ///   | '-' |
            Console.WriteLine(" +-----+");           ///   +-----+
        }
    }
}
