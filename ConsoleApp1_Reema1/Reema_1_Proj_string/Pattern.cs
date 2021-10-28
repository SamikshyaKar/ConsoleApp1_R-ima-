using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
   public  class Pattern
    {
        public static void DisplayPattern()
        {
            Console.WriteLine(" Pattern MATCHING ");
            Console.WriteLine(" ENTER A  STRING " );
            char[] str = new char[200];
            str = Console.ReadLine().ToCharArray();
            Console.WriteLine(" Enter a PATTERN ");
            char[] pattern = new char[50];
            pattern = Console.ReadLine().ToCharArray();
            int n1 = str.Length - 1;
            int n2 = pattern.Length - 1;
            int i = 0, j = 0, k = 0, found = 0, count=0 ;
            while (i<=n1)
            {
                k = i; j = 0;

                while(str[k]==pattern[j] && j <n2)
                {
                    k++;
                    j++;
                }
               if(j==n2)
                {
                    found = 1;
                    count++;
                }
                i++;

            }

            if(found==1)
            {
                Console.WriteLine(" PATTERN found {0} times ", count);
            }
            else
            {
                Console.WriteLine(" PATTERN NOT FOUND ");
            }

        }

    }
}
