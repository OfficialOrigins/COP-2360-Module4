//Perfect Module 4 Exercise 4.1 
using System;

class Program 
{
  public static void Main (string[] args) 
  {
    //vars 
    int number; 
    int sum = 0; 

    //code 
    Console.Write("Please enter a number between 1 - 10000: ");
    number = int.Parse(Console.ReadLine()); 

    for(int i = 1; i < number; ++i)
    {
      if(number % i == 0){
        sum += i; 
      }
    }

    if(number == sum)
    {
      Console.WriteLine("This number is a perfect number!");
    }

    if(number != sum)
      Console.WriteLine("This number is not a perfect number!");
    }
}

//HomeSales Module 4: Exercise 4.2 
using System;

class Program
{
    static void Main(string[] args)
    {
        int totalSalesD = 0;
        int totalSalesE = 0;
        int totalSalesF = 0;
        int saleAmount = 0;
        string salesChoice;

        while (true)
        {
            Console.Write("Enter salesperson initial (D, E, F) or 'Z' to stop: ");
            salesChoice = Console.ReadLine().ToUpper();

            if (salesChoice == "Z")
                break;

            if (salesChoice != "D" && salesChoice != "E" && salesChoice != "F")
            {
                Console.WriteLine("Error, invalid salesperson selected. Please try again.");
            }
            else
            {
                Console.Write("Enter the sale amount: ");
                saleAmount = Convert.ToInt32(Console.ReadLine());

                if (salesChoice == "D")
                {
                    totalSalesD += saleAmount;
                }
                else if (salesChoice == "E")
                {
                    totalSalesE += saleAmount;
                }
                else if (salesChoice == "F")
                {
                    totalSalesF += saleAmount;
                }
            }
        }

        int grandTotal = totalSalesD + totalSalesE + totalSalesF;

        Console.WriteLine("Salesperson D total: " + totalSalesD);
        Console.WriteLine("Salesperson E total: " + totalSalesE);
        Console.WriteLine("Salesperson F total: " + totalSalesF);
        Console.WriteLine("Grand Total: " + grandTotal);

        if (totalSalesD > totalSalesE && totalSalesD > totalSalesF)
        {
            Console.WriteLine("Highest Sale: D");
        }
        else if (totalSalesE > totalSalesD && totalSalesE > totalSalesF)
        {
            Console.WriteLine("Highest Sale: E");
        }
        else if (totalSalesF > totalSalesD && totalSalesF > totalSalesE)
        {
            Console.WriteLine("Highest Sale: F");
        }
    }
}
