using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
   public class Read_Count
    {
        public static void ReadCount()
        {
            Console.WriteLine(" Enter a string or Sentence  ");
            //string[] str = new string[100];
            string str = Console.ReadLine();
            char[] TextStr = str.ToCharArray();
            char[] textstr = new char[100];
            textstr = str.ToCharArray();
            int i = 0, count=0;
            while( i < TextStr.Length)
            {
                 if(str[i] == ' ' && str[i+1] != ' ')
                {
                    count++;                    
                }
                i++;
            }

            Console.WriteLine(" The Number of Words are : " + (count+1));
        }
    }
}
