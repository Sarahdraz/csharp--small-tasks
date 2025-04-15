using System;
using Task1;
int Num;
int Max;
int Min;
Task3.Main();
Task2.Main();
Console.WriteLine("Please Enter Your Numbers:");
//Num = 0;
Console.WriteLine("Enter Number 1:"); 
Num = int.Parse(Console.ReadLine()); 
// It caused an error when starting the for loop at 1 because Num was not defined. So,I initialized Num by assigning it to Max and Min as an initial value
Max = Min = Num;

for (int i = 2; i <= 10; i++)
{
    Console.WriteLine($"Enter Number {i} : ");
    Num=int.Parse(Console.ReadLine());
    if (Num< Min)
    {
     Min = Num;
    }
    if (Num > Max)
    {
        Max = Num;
    }
  //  Console.WriteLine($"Minimum: {Min}, Maximum: {Max}");
}
Console.WriteLine($"Minimum: {Min}, Maximum: {Max}");