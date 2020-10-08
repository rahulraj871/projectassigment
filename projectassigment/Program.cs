using System;

namespace projectassigment
{
    class Program
    {
        static void Main(string[] args)
        {

            int sidea, sideb, sidec, menu;
            Console.Write("\n\n");
            Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
            Console.Write("----------------------------------------------------------------");
            ShowMenu();

            menu = Convert.ToInt32(Console.ReadLine());
         

            if (menu == 1)
            {
                TriangleSolver.Analyze(out sidea, out sideb, out sidec);
            }
            if (menu == 2)
            {

                System.Environment.Exit(1);

            }
            else
            {

                ShowMenu();
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {


                    TriangleSolver.Analyze(out sidea, out sideb, out sidec);


                }

                if (menu == 2)
                {

                    System.Environment.Exit(1);

                }
            }
        }

        private static void ShowMenu()
        {
            Console.Write("\n\n");
            Console.Write("1: Enter Traingle Dimension");
            Console.Write("\n\n");
            Console.Write("2: Exit");
            Console.Write("\n\n");
        }
    }


        static class TriangleSolver
        {
            public static void Analyze(out int sidea, out int sideb, out int sidec)
            {
                Console.Write("Input side 1 of triangle: ");
                sidea = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                sideb = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                sidec = Convert.ToInt32(Console.ReadLine());



                if (sidea == sideb && sideb == sidec)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (sidea == sideb || sidea == sidec || sideb == sidec)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                }
            }
        }
    
}
