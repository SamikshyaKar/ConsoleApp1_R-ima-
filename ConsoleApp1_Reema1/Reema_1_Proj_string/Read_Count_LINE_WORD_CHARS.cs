using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
   public  class Read_Count_LINE_WORD_CHARS
    {
        public static void DisplayReadCountLineCHARWORD()
        {
            Console.WriteLine(" Enter a Sentence ");
            string Str = Console.ReadLine();
            char[] Textstr = Str.ToCharArray();
            int i=0, wordCount = 0, LineCount = 0, charCount = 0;
            //if (Textstr == null )
            //{
            //    throw new ArgumentNullException("String is NULL");
            //}
            //while(Textstr[i] != '*')
            //{                
            //    Console.Write(Textstr[i]);
            //    i++;
            //}
            Console.WriteLine();
            while (i< Textstr.Length)
            {
                if (Textstr[i] == ' ' && Textstr[i + 1] != ' ')
                {
                    wordCount++;
                }

             
                if (Textstr[i] == '\n' || i ==79 )
                {
                    LineCount++;
                }

                charCount++;
                i++;
            }
            Console.WriteLine(" The No Of Words are :: " + (wordCount+1));
            Console.WriteLine(" The No Of Lines are :: " + (LineCount + 1));
            Console.WriteLine(" The No Of Characters  are :: " + (charCount));
            Console.WriteLine(" Enter another String  with * in the END " );
            string sstr = Console.ReadLine();
            char[] charsstr = sstr.ToCharArray();
            char[] exp=new char[10];
            int j = 0;
            while(j< sstr.Length && sstr[j] != '*')
            {
                exp[j] = charsstr[j];
                j++;
            }
            int p = 0, char2 = 0,word2=0, line2 = 0;
            while (p<exp.Length)
            {
                Console.Write(exp[p]);

                if (p == 79 || exp[p] == '\n')
                {
                    line2++;
                }
                if(exp[p]==' ' && exp[p+1] !=' ')
                {
                    word2++;
                }
                p++;
                char2++;
            }                   
          
            Console.WriteLine();
            Console.WriteLine(" The no of  New LINE  is " + (line2+1) + " Chars are  " + char2 + " Words are " + (word2+1) );
        }
    }
}
