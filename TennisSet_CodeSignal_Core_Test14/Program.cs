using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSet_CodeSignal_Core_Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Score1");
            int score1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Score2");
            int score2 = int.Parse(Console.ReadLine());
            Console.WriteLine(tennisSet(score1,score2));
        }
        static bool tennisSet(int score1, int score2)
        {
            if (score1 == 6 && score1 < 7 && score2 < 5)
            {
                return true;
            }
            else if (score2 == 6 && score2 < 7 && score1 < 5)
            {
                return true;
            }
            else if (score1 == 7 && score1 < 8 && score2 < 5)
            {
                return false;
            }
            else if (score2 == 7 && score2 < 8 && score1 < 5)
            {
                return false;
            }
            else if (score1 == 7 && score1 < 8 && score2 <= 6)
            {
                return true;
            }
            else if (score2 == 7 && score2 < 8 && score1 <= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
