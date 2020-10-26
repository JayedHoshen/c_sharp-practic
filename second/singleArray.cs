// student result calculate software 
// single dimentional array

using System;
using System.Collections.Generic;
using System.Text;

namespace stud {
    // input class start
    class studentInput {
        // first class variable declaretion
        int id, m1, m2, m3, tot, avg;
        string name, res, grade;

        // input method (input class)
        public void getInput() {
            Console.Write("Enter the student ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter the student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark1, mark2, mark3... ");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
        }

        // grade calculation method (input class)
        public void gradeCal() {
            tot = m1 + m2 + m3;
            avg = tot / 3;

            if (m1 >= 45 && m2 >= 45 && m3 >= 45) {
                res = "pass";
                
                if (avg >= 85 && avg <= 100) {
                    grade = "A";
                }
                else if (avg <= 84 && avg >= 70) {
                    grade = "B";
                }
                else {
                    grade = "C";
                }
            }
            else {
                res = "Fail";
                grade = "-";
            }
        }

        // output formated method (input class)
        public void display () {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", id, name, m1, m2, m3, tot, avg, res, grade);
        }
    }

    // output class
    class studePrint {
        // the main method
        static void Main(string[] args) {
            int i, n;
            studentInput[] s = new studentInput[20]; // call studentInput class

            // progra's input here start
            Console.WriteLine("Enter the no of students: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                s[i] = new studentInput();
                s[i].getInput(); // call getInput method
                s[i].gradeCal(); // call gradeCal method
            }

            // program's output here start
            Console.WriteLine("ID\tName\tMarks1\tMarks2\tMarks3\tTotal\tAvg\tResult\tGrade");

            for (i = 1; i <=n; i++) {
                s[i].display();
            }

            Console.ReadLine();
        }
    }
}
