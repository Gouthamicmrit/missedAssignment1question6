using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missedAssignment1question6
{
    internal class Program
    {
        int[] csharp;
        int[] html;
        int[] sql;
        public Program(int num)
        {
            csharp = new int[num];
            html = new int[num];
            sql = new int[num];

        }
        public void acceptMarks(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter CSharp marks of student {0}", i + 1);
                csharp[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter html marks of student {0}", i + 1);
                html[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter sql marks of student {0}", i + 1);
                sql[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------");
            }
        }
        public void dispalyResult(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int total = csharp[i] + html[i] + sql[i];
                int avg = total / 3;
                if (avg > 50)
                {
                    Console.WriteLine("Student{0} Total Marks:{1} Avg.Marks:{2} Result:pass", i + 1, total, avg);
                }
                else
                {
                    Console.WriteLine("Student{0} Toatl Marks:{1} Avg.marks:{2} result:fail", i + 1, total, avg);
                }
            }
        }
        public static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter number of students:");
            num = int.Parse(Console.ReadLine());
            Program sr = new Program(num);
            sr.acceptMarks(num);
            sr.dispalyResult(num);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}


