using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
    public class Pallindrome
    {
        public static  void DsiplayPallindrome()
        {
            char[] str = new char[100];
            Console.WriteLine(" CHECK PALLINDROME ");
            Console.WriteLine(" Enter a string " );
             str = Console.ReadLine().ToCharArray();
            int n = str.Length - 1;
            int j = n;
            int i = 0;

            while (i<=n/2)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else break;

            }
            if(i>=j)
            {
                Console.WriteLine(" PALLINDROME "  );
            }
            else
            {
                Console.WriteLine(" NOT PALLINDROME ");
            }

        }
    }
}
