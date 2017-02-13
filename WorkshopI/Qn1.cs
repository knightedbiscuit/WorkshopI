using System;

namespace WorkshopI
{
    class Qn1
    {
        static void Main()
        {
            Console.Write("Enter your amount in dollar.cent: $ ");
            string input = Console.ReadLine();

            int money = 100*Convert.ToInt32(input);  //float and double data store approximation of the variable. Use decimal or integer
            int count100 = 0; int count50 = 0; int count20 = 0; int count5 = 0;
            

            while (money >=100)
            {
                count100++;
                money = money - 100;
            }

            while (money>=50)
            {
                count50++;
                money = money - 50;
            }

            while (money >= 20)
            {
                count20++;
                money = money - 20;
            }

            while (money >= 5)
            {
                count5++;
                money = money - 5;
            }

            Console.WriteLine(count100);
            Console.WriteLine(count50);
            Console.WriteLine(count20);
            Console.WriteLine(count5);
        }

    }
}
