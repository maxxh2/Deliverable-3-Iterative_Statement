/*Name: Maxx Hernandez
  Date: 01/26/2023
  Drescription: C# Deliverable(3) Iterative Statements
*/

namespace deliverable3_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int input = 0;
                string series = "";

                while (true)
                {
                    Console.WriteLine("Enter an integer number between 1-100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 0 && input <= 100)
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Specify the series type: Even or Odd: ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }


                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter either Even or Odd");
                }

            }
            catch
            {
                Console.WriteLine("Please, enter a numeric value for the input");
                Console.WriteLine("Or, a string value for the series");
            }
       }
    }
}