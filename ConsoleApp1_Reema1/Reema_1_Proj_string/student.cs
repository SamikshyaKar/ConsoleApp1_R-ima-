using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
   public class student
    {
        public static void DisplayStudent()
        {
            Console.WriteLine(" STUDENT INFORMATION ");
            Console.WriteLine(" Enter the number of students ");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[40];
            for(int i=0; i<n; i++)
            {
                Console.Write (" Enter the Student {0} :: " , i+1 );
                names[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine(" The Student Names are " );
            foreach(string str in names)
            {
                Console.Write(str + " " + " " );
            }
            Console.WriteLine();
            for(int i=0; i<n;i++)
            {
                Console.Write(names[i] + " " );
            }

        }
    }
}
