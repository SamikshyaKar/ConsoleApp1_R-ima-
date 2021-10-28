using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Reema1.Reema_1_Proj_string
{
    public class Quiz1_Prog1
    {
        public static void implementQuiz()
        {
            //string[] quest= new string [5];
            //char[,] option1= new char[3,20];
            //char[,] option2 = new char[3, 20];
            //char[,] option3 = new char[3, 20];
            //char[,] option4 = new char[3, 20];
            //char[,] option5 = new char[3, 20];
            int[]  response= new int[5];
            int[] correct_ans = new int[5];
            int options = 0;  int marks = 0;

            //string cpy1 = String.Concat(quest[0], "CAPITAL");
            //string[] strquest = { "Name of the Capital of India " };
            //string[] strquest = new string[] { "Name of the Capital of India " };
            string[] strquest = new string[5];
            strquest[0]=   "  Name of the Capital of India ";
            string[] stroption1 = new string[3];
            stroption1[0] = "1. Mumbai";
            stroption1[1] = "2. Delhi";
            stroption1[2] = "3. Chennai";
            correct_ans[0] = 1;
            strquest[1] = "Name of the National Bird of India ";
            string[] stroption2 = new string[3];
            stroption2[0] = "1. Peacock";
            stroption2[1] = "2. BIRD";
            stroption2[2] = "3. CROW";
            correct_ans[1] = 0;
            strquest[2] = "Name of the First PM  of India ";
            string[] suboption3 = new string[3];
            suboption3[0] = " 1.   J. L . NEHERU";
            suboption3[1] = " 2.   I. Gandhi";
            suboption3[2] = " 3.   PRASAD";
            correct_ans[2] = 0;

            strquest[3] = "Name of the Present PM  of India ";
            string[] suboption4 = new string[3];
            suboption4[0] = " 1.   J. L . NEHERU";
            suboption4[1] = " 2.   I. Gandhi";
            suboption4[2] = " 3.   MODI";
            correct_ans[3] = 2;
            strquest[4] = "Name of the National Animal of India ";
            string[] suboption5 = new string[3];
            suboption5[0] = " 1.   LION";
            suboption5[1] = " 2.  TIGER ";
            suboption5[2] = " 3.   BUFFALO";
            correct_ans[4] = 1;


            do
            {
                Console.WriteLine(" THE QUIZ SESSION STARTED ");
                Console.WriteLine( " ************************* ");
                Console.WriteLine(" 1.  Please Provide the Questions " );
                Console.WriteLine(" 2.  Please Display the Answers " );
                Console.WriteLine(" 3.  Please Display the MARKS " );
                Console.WriteLine(" 4.   EXIT   " );
                Console.WriteLine(" ************************** " );
                Console.WriteLine(" Enter Options ");
                options =int.Parse( Console.ReadLine());

                switch(options)
                {
                    case 1:
                        Console.WriteLine(" Start Quizz - Question ");
                        Console.WriteLine(strquest[0]);
                        for (int x = 0; x < 3; x++)
                            Console.WriteLine(stroption1[x]);
                        Console.WriteLine("***********");
                        Console.WriteLine(" Enter your RESPONSE ");
                        response[0] = int.Parse(Console.ReadLine());


                        Console.WriteLine("***********");

                        Console.WriteLine(" Next Question ");

                        Console.WriteLine(strquest[1]);
                        for (int p = 0; p < 3; p++)
                            Console.WriteLine(stroption2[p]);
                        Console.WriteLine("***********");
                        Console.WriteLine(" Enter your RESPONSE ");
                        response[1] = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ******************* ");
                        Console.WriteLine(" Next Question " );

                        Console.WriteLine(strquest[2]);
                        for(int i=0;i<3;i++ )
                        {
                            Console.WriteLine(suboption3[i]);
                        }
                        Console.WriteLine(" Enter your RESPONSE ");
                        response[2] = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ******************* ");
                        Console.WriteLine(" Next Question ");

                        Console.WriteLine(strquest[3]);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(suboption4[i]);
                        }
                        Console.WriteLine(" Enter your RESPONSE ");
                        response[3] = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ******************* ");
                        Console.WriteLine(" Next Question ");

                        Console.WriteLine(strquest[4]);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(suboption5[i]);
                        }
                        Console.WriteLine(" Enter your RESPONSE ");
                        response[4] = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                        Console.WriteLine(" CHECK Answers ");
                        //Console.WriteLine(quest[0],stroption1[correct_ans[0]]);
                        Console.WriteLine(strquest[0]);
                        Console.WriteLine(stroption1[correct_ans[0]]);

                        Console.WriteLine(strquest[1]);
                        Console.WriteLine(stroption2[correct_ans[1]]);

                        Console.WriteLine(strquest[2]);
                        Console.WriteLine(suboption3[correct_ans[2]]);

                        Console.WriteLine(strquest[3]);
                        Console.WriteLine(suboption4[correct_ans[3]]);

                        Console.WriteLine(strquest[4]);
                        Console.WriteLine(suboption5[correct_ans[4]]);
                        break;

                    case 3:
                        Console.WriteLine(" check your  marks ");
                        //marks = 0;
                        for (int j = 0; j < 4; j++)
                        {
                            if (correct_ans[j] +1==response[j])
                            {
                                marks++;
                            }
                        }

                        Console.WriteLine(" Marks = " + marks);
                        break;
                }



            } while (options != 4);




        }



    }
}
