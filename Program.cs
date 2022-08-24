using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "Y";

            string id = "", name = "", age = "", stream = "", mobile = "";
            int n;

            for (; cont.ToUpper() == "Y";)
            {

                Console.WriteLine("Press 1 to enter student details");
                Console.WriteLine("Press 2 to print student details");
                Console.WriteLine("Press 3 to check if the input is palindrome or not");
                Console.WriteLine("Press 4 to check if the input is an armstrong number or not");

                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the id of the student: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter the name of the student: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the ages: ");
                        age = Console.ReadLine();
                        Console.WriteLine("Enter the stream: ");
                        stream = Console.ReadLine();
                        Console.WriteLine("Enter the mobile no.: ");
                        mobile = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("id is " + id);
                        Console.WriteLine("Name is " + name);
                        Console.WriteLine("age is " + age);
                        Console.WriteLine("stream is " + stream);
                        Console.WriteLine("Mobile number is " + mobile);
                        break;

                    case 3:
                        Console.WriteLine("Enter the string: ");
                        string a = Console.ReadLine();
                        int i, j;
                        for (i = 0, j = a.Length - 1; i <= j; i++, j--)
                        {
                            if (a[i] != a[j])
                            {
                                Console.WriteLine("Input is not palindrome");
                                break;
                            }
                        }
                        if (i > j)
                            Console.WriteLine("Input is palindrome");
                        break;

                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N): ");
                cont = Console.ReadLine();
            }
        }
    }
}
