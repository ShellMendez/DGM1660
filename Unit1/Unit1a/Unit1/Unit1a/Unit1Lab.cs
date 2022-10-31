using System;

//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function

//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
// using System;
// using CorrectTheErrors;
// public class Lab1{
// public static void Main()
// {
    
//     Console.WriteLine("Hello It works");
// }
// }

class Operators 

{

  public int x = 100;
  public int y = 5;



    public void Addition()
    {
        int theSum = x + y;
        int sum1 = x +1;
        sum1 += 100;


        Console.WriteLine(sum1);
        
    }
    public void Subtration()
    {
        int sub1 = x-y;
        Console.WriteLine(sub1);
    
    }
    public void Division()
    {
        int div1 = x/y;
        Console.WriteLine(div1);
        Console.WriteLine(div1 +=100);
        Console.WriteLine("It worked as it should");
        bool DivisionSelected = true;
        Console.WriteLine(DivisionSelected);
        Remainder();


    }
    public void Remainder()
    {
        Console.WriteLine("And the remainder is");

        int remain = x%y;
        Console.WriteLine(remain);


    }
    public void Compare()
    {
        Console.WriteLine("We are comparing now");
        Console.WriteLine(x<7);
        Console.WriteLine(x>y);


    }
}

class Program
    {
    static void Main(string[] args)
    {
      Operators myObj = new Operators();
        myObj.Addition();
        myObj.Subtration();
        myObj.Division();
        myObj.Compare();





    }
  }


