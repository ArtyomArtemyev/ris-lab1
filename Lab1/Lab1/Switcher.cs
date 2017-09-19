using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Switcher
    {
        public int getUserSolve() {
            int userSolve = 0;
            Console.WriteLine("1 - Show objects");
            Console.WriteLine("2 - Add object");
            Console.WriteLine("3 - Delete object");
            Console.WriteLine("4 - Change object");
            Console.WriteLine("5 - Sort objects");
            Console.WriteLine("6 - Find object(s)");
            Console.WriteLine("7 - Exit");
            Console.WriteLine("Enter:");
            try {
                userSolve = int.Parse(Console.ReadLine());
            } catch (System.FormatException) {
                Console.WriteLine("Please enter number!");
                return getUserSolve();
            }
            if (userSolve == 1 || userSolve == 2 ||
               userSolve == 3 || userSolve == 4 ||
               userSolve == 5 || userSolve == 6 ||
               userSolve == 7)
            {
                return userSolve;
            }
            else { return getUserSolve(); }
        }
    }
}
