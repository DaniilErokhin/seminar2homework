//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("input a three digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second number of your number: " + stringNumber[1]);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
Console.Write("Input a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("Third number is: " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("No third number");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Input a number that means the day of the week: ");
int daynumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int daynumber)
{
if(daynumber == 6 || daynumber == 7)
{
    Console.WriteLine("This day is a holyday");
}
else if (daynumber < 1 || daynumber > 7)
{
    Console.WriteLine("Thats not the day of the week");
}
else
{
    Console.WriteLine("This day is not a holiday");
}
}
CheckingTheDayOfTheWeek(daynumber);
*/