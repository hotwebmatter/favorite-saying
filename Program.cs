using System;
using static System.Console;

namespace favorite_saying
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetInput("What is your name? ");
            string saying = GetInput("What is your favorite saying? ");
            WriteLine(DisplayMessage(name, saying));
        }

        static string GetInput(string label)
        {
            Write("{0}", label);
            string result = ReadLine();
            return result;
        }

        static string GenerateLine(int reps)
        {
            string result = string.Empty;
            for (int i = 0; i < reps; i++)
            {
                result += String.Format("<>");
            }
            return result;
        }

        static string DisplayMessage(string name, string saying)
        {
            string result = string.Empty;
            result += string.Format("{0}\n", GenerateLine(20));
            result += String.Format("{0, 18} {1, 18}\n", "Name:", name);
            result += String.Format("{0, 18} {1, 18}\n", "Favorite saying:", saying);
            result += string.Format("{0}\n", GenerateLine(20));
            return result;
        }
    }
}
