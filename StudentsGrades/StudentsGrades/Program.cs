using System;

namespace StudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!, How many students will be entered?");

            //var sizeString = Console.ReadLine();
            //int size = Convert.ToInt32(sizeString);
            //OR

            int size = int.Parse(Console.ReadLine());
            var studentName = new string[size];
            double[] studentGrade = new double[size];
            var results = new string[size];

            //To stored student INFO
            StudentINFO( studentName, studentGrade, results, size);
            //To Print StudentINFO
            print(studentName, studentGrade, results);

            Console.WriteLine("Do you want to modify the entries?{ 1(yes) / 0(no) }");
            int flag = int.Parse(Console.ReadLine());
            while(flag == 1)
            {
                Console.WriteLine("\nEnter ID number");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter 1 to change name, or 2 to change grade");
                int c = int.Parse(Console.ReadLine());
                if(c == 1)
                {
                    StudentNameModify(id, studentName);
                }
                else
                {
                    StudentGradeModify(id, studentGrade, results);
                }
                print(studentName, studentGrade, results);

                Console.WriteLine("\nDo you want to modify the entries?{ 1(yes) / 0(no) }");
                flag = int.Parse(Console.ReadLine());
            }
                        
            Console.WriteLine("\nData saved.");
            

        }

        //To stored student INFO
        static void StudentINFO(string[] studentName,double[] studentGrade, string[] results,int size)
        {
            int count = 0;
            while (count < size)
            {
                Console.WriteLine("\nEnter Student Name:");
                var name = Console.ReadLine();
                studentName[count] = name;
                Console.WriteLine("Enter Student Grade:");
                double grade = double.Parse(Console.ReadLine());
                studentGrade[count] = grade;
                if (grade >= 60)
                    results[count] = "Passed";
                else
                    results[count] = "Failed";

                count++;

            }
        }

        //To modify the entries
        static void StudentINFOModify(int id, string[] studentName, double[] studentGrade, string[] results)
        {
            Console.WriteLine("\nEnter Student Name");
            var name = Console.ReadLine();
            studentName[id - 1] = name;
            Console.WriteLine("Enter Student Grade");
            double grade = double.Parse(Console.ReadLine());
            studentGrade[id - 1] = grade;
            if (grade >= 60)
                results[id-1] = "Passed";
            else
                results[id-1] = "Failed";
        }

        //To modify the name
        static void StudentNameModify(int id, string[] studentName)
        {
            Console.WriteLine("\nEnter student name");
            var name = Console.ReadLine();
            studentName[id - 1] = name;
        }

        // To modify the grade
        static void StudentGradeModify(int id, double[] studentGrade, string[] results)
        {
            Console.WriteLine("\nEnter student grade");
            double grade = double.Parse(Console.ReadLine());
            studentGrade[id - 1] = grade;
            if (grade >= 60)
                results[id - 1] = "Passed";
            else
                results[id - 1] = "Failed";
        }

        //To Print StudentINFO
        static void print(string [] studentName, double[] studentGrade, string[] results)
        {
            Console.WriteLine();
            Console.WriteLine("id|" + "\t" + "Name" + "\t" + "Grade" + "\t" + "Result");
            Console.WriteLine("--|-------------------------------------");
            for (int i=0; i < studentName.Length; i++)
            {
                
                Console.WriteLine(i+1 + " |\t" + studentName[i] + "\t" + studentGrade[i] + "\t" + results[i]);
            }
            Console.WriteLine();

         
            //An Other way
            /*foreach (var student in studentsName)
            {
                Console.Write(student + "\t");
            }
            Console.WriteLine();
            foreach (double student in studentsGrade)
            {
                Console.Write(student + "\t");
            }
            Console.WriteLine();
            foreach (var student in results)
            {
                Console.Write(student + "  ");
            }
            */

        }
    }
}

