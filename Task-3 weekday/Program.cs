//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день 
//выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7");
//Указание типа данных
int dayNumber = int.Parse(Console.ReadLine()!);

if (dayNumber > 8) 
    Console.WriteLine ("Неверно введенное число");

else
{
   if (dayNumber<=5)
   Console.WriteLine ("День не является выходным");

   if(dayNumber>5 && dayNumber<7)
   Console.WriteLine ("Этот день является выходным");
}


