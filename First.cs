using System;
// Variables
int myNum = 1;
int myNum2 = 22;
int myNum3 = 27;
string myString = "Hello";
string[] MyFamily = {"Mom" , "Dad" , "Brother","Sister"};
//////////////////////Printing Stuff///////////////////////////////
Console.WriteLine(myNum);
Console.WriteLine(myString);
Console.WriteLine("---------------------");

foreach (string i in MyFamily)
{
    Console.WriteLine(i);
}


myNum += 25; //Add int
Console.WriteLine(myNum);
myNum += myNum2; //Add int with another Var
Console.WriteLine(myNum);
myNum *= 10;
Console.WriteLine(myNum);
myNum /= myNum3;
Console.WriteLine(myNum);
