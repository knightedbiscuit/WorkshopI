using System;

namespace WorkshopI
{
    class Qn2
    {
        static void Main()
        {
            Random r = new Random();
            int num = 0;
            int[] countArr = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 50; i++)
            {
                num = r.Next(0, 10);

                for (int j = 0; j < 10; j++)
                {
                    if (j == num)
                    {
                        countArr[j]++;
                        break;
                    }
                }      
            }

            Console.WriteLine("Number\tCount");
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("  {0}\t  {1}", k, countArr[k]);
            }
           
        }

    }
}