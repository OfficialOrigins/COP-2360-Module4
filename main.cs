// Perfect Module 4 Exercise 4.1 
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
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int totalSalesD = 0;
//         int totalSalesE = 0;
//         int totalSalesF = 0;
//         int saleAmount = 0;
//         string salesChoice;

//         while (true)
//         {
//             Console.Write("Enter salesperson initial (D, E, F) or 'Z' to stop: ");
//             salesChoice = Console.ReadLine().ToUpper();

//             if (salesChoice == "Z")
//                 break;

//             if (salesChoice != "D" && salesChoice != "E" && salesChoice != "F")
//             {
//                 Console.WriteLine("Error, invalid salesperson selected. Please try again.");
//             }
//             else
//             {
//                 Console.Write("Enter the sale amount: ");
//                 saleAmount = Convert.ToInt32(Console.ReadLine());

//                 if (salesChoice == "D")
//                 {
//                     totalSalesD += saleAmount;
//                 }
//                 else if (salesChoice == "E")
//                 {
//                     totalSalesE += saleAmount;
//                 }
//                 else if (salesChoice == "F")
//                 {
//                     totalSalesF += saleAmount;
//                 }
//             }
//         }

//         int grandTotal = totalSalesD + totalSalesE + totalSalesF;

//         Console.WriteLine("Salesperson D total: " + totalSalesD);
//         Console.WriteLine("Salesperson E total: " + totalSalesE);
//         Console.WriteLine("Salesperson F total: " + totalSalesF);
//         Console.WriteLine("Grand Total: " + grandTotal);

//         if (totalSalesD > totalSalesE && totalSalesD > totalSalesF)
//         {
//             Console.WriteLine("Highest Sale: D");
//         }
//         else if (totalSalesE > totalSalesD && totalSalesE > totalSalesF)
//         {
//             Console.WriteLine("Highest Sale: E");
//         }
//         else if (totalSalesF > totalSalesD && totalSalesF > totalSalesE)
//         {
//             Console.WriteLine("Highest Sale: F");
//         }
//     }
// }


//Module 5: Reivse program 4.2 

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int saleAmount = 0;
//         string salesChoice;

//         //Arrays 
//         string[] Intials = {"D", "E", "F",}; 
//         string[] Names = {"Danielle", "Edward", "Francis"};

//         //Double array 
//         int[] salesTotal = new int[3]; 

//         while (true)
//         {
//             Console.Write("Enter salesperson initial (D, E, F) or 'Z' to stop: ");
//             salesChoice = Console.ReadLine().ToUpper();

//             if (salesChoice == "Z")
//                 break;

//             if (salesChoice != Intials[0] && salesChoice != Intials[1] && salesChoice != Intials[2])
//             {
//                 Console.WriteLine("Error, invalid salesperson selected. Please try again.");
//             }
//             else
//             {
//                 Console.Write("Enter the sale amount: ");
//                 saleAmount = Convert.ToInt32(Console.ReadLine());

//                 if (salesChoice == Intials[0])
//                 {
//                     Console.WriteLine("You chose: " + Names[0]);
//                     salesTotal[0] += saleAmount;
//                 }
//                 else if (salesChoice == Intials[1])
//                 {
//                     Console.WriteLine("You chose: " + Names[1]);
//                     salesTotal[1] += saleAmount;
//                 }
//                 else if (salesChoice == Intials[2])
//                 {
//                     Console.WriteLine("You chose: " + Names[2]);
//                     salesTotal[2]+= saleAmount;
//                 }
//             }
//         }

//         int grandTotal = salesTotal[0] + salesTotal[1] + salesTotal[2];

//         Console.WriteLine("Salesperson D total: " + salesTotal[0]);
//         Console.WriteLine("Salesperson E total: " + salesTotal[1]);
//         Console.WriteLine("Salesperson F total: " + salesTotal[2]);
//         Console.WriteLine("Grand Total: " + grandTotal);

//         if (salesTotal[0] > salesTotal[1] && salesTotal[0] > salesTotal[2])
//         {
//             Console.WriteLine("Highest Sale: D");
//         }
//         else if (salesTotal[1] > salesTotal[0] && salesTotal[1] > salesTotal[2])
//         {
//             Console.WriteLine("Highest Sale: E");
//         }
//         else if (salesTotal[2] > salesTotal[0] && salesTotal[2] > salesTotal[1])
//         {
//             Console.WriteLine("Highest Sale: F");
//         }
//     }
// }
