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
  