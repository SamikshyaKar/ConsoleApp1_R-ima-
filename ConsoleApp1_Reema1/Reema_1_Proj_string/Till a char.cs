using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
    // wrong 
    public class Till_a_char
    {
        public static void displaytillachar1()
        {
            Console.WriteLine();
            char[] str = new char[100];
            int i = 0;

            Console.WriteLine(" Enter a * at the END ");
            Console.WriteLine(" Enter a text ");
            str[i] = Console.ReadLine()[0];

            while (str[i] != '*')
            {
                i++;
                str[i] = Console.ReadLine()[0];
                //str[i]= Console.ReadKey().KeyChar;
                //Console.Write(str[i] + " " );
            }

            Console.WriteLine(" Your OUTPUT SHOULD BE ");
            i = 0;
            while (i < str.Length)
            {
                Console.Write(str[i] + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(" The count of the characters " + i);
        }
        public static void displaytillachar()
        {
            Console.WriteLine();
            string[] str = new string[100];
            int i = 0;

            Console.WriteLine(" Enter a * at the END ");
            Console.WriteLine(" Enter a text ");
            str[i] = Console.ReadLine();

            while (str[i] != "*")
            {
                i++;
                str[i] = Console.ReadLine();
                //str[i]= Console.ReadKey().KeyChar;
                //Console.Write(str[i] + " " );
            }

            Console.WriteLine(" Your OUTPUT SHOULD BE ");
            i = 0;
            while (i < str.Length)
            {
                Console.Write(str[i] + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(" The count of the characters " + i);
        }

        public static void displaytillachar2()
        {
            Console.WriteLine();
            char[] str = new char[100];
            int i = 0;

            Console.WriteLine(" Enter a * at the END ");
            Console.WriteLine(" Enter a text ");
            str[i] = Console.ReadKey().KeyChar;

            while (str[i] != '*')
            {
                i++;
                //str[i] = Console.ReadLine()[0];
                str[i] = Console.ReadKey().KeyChar;
                //Console.Write(str[i] + " " );
            }

            Console.WriteLine(" Your OUTPUT SHOULD BE ");
            i = 0;
            while (i < str.Length)
            {
                Console.Write(str[i] + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(" The count of the characters " + i);
        }

        public static void displaytillachar3()
        {
            Console.WriteLine();
            int count = 0, i=0;
            Console.WriteLine(" Enter a * at the End ");
            Console.WriteLine(" Enter a String ");
            string source = Console.ReadLine();
            char[] testchars = source.ToCharArray();
            int length = testchars.Length;
            Console.WriteLine(" The OUTPUT SHOULE BE ");
            while(testchars[i] != '*')
            {
                Console.Write(testchars[i]);
                i++;
            }
            for (int n = 0; n < length; n++)
            {
                if (testchars[n] == '*')
                    count++;
            }
            Console.WriteLine();
            Console.WriteLine(" COUNT of the * CHARACTERS " + count);
            Console.WriteLine(" OHH the New OUTPUT is " );
            int j = 0;
            Console.WriteLine(" EXP1");
            while (testchars[j] != '*')
            {
                int p = j;
                testchars[p] = testchars[j];
                j++;
                Console.Write(testchars[p]);
            }
            Console.WriteLine();
            Console.WriteLine(" Count of characters before *  are :::::::" + j);
            Console.WriteLine(" SECOND EXP1");
            for(int p=0;p<testchars.Length;p++)
            {
                Console.Write(testchars[p]);
            }
            Console.WriteLine();
        }
    }
}
