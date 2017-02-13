using System;


namespace WorkshopI
{
    class Q2_another
    {
        static void Main()
        {
            Random r = new Random();
            int num = 0;
            string[] countArr = new string[10];

            for (int i = 0; i < 50; i++)
            {
                num = r.Next(0, 10);

                for (int j = 0; j < 10; j++)
                {
                    if (j == num)
                    {
                        countArr[j]+="*";
                        break;
                    }
                }
            }

            Console.WriteLine("Number");
            for (int k = 0; k < 10; k++)
            {
                Console.Write("  {0}  ",k);
                Console.Write(countArr[k]);
                Console.WriteLine();
            }
        }
    }
}
