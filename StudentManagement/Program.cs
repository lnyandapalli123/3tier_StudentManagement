// See https://aka.ms/new-console-template for more information

using StudentManagement.Core.Contracts.Services;
using StudentManagent.Ui.UI;
using System;

namespace StudentManagement
{
    public class Program
    {
        private static readonly StudentUI studentUI = new StudentUI();
        private static readonly CourseUI courseUI = new CourseUI();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Management System");
            int choice = 0;


            do
            {
                Console.WriteLine("Select the following services:");
                Console.WriteLine("1. Student Services");
                Console.WriteLine("2. Course Services");
                Console.WriteLine("3. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentUI.StudentOptions();
                        break;

                    case 2:
                        courseUI.CourseOptions();
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Student Management System");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 3);
        }
    }
}