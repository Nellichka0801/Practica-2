//  Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.Через строку решать 
//нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//1. Вводим число
//2. Проверяем число <1000
//3. Меньше тысячи Выводим остаток

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
if (number<100)
{
  Console.WriteLine("Третьей цифры в числе нет");
}
else
{
  int threeDigit(int number)
    {
      while(number>=1000)
      {
        number=number/10;
      }
      return number%10;
    }
   
Console.WriteLine("третья цифра  " + threeDigit(number));
}


//int remainsDigit(int number);
//while (number>=1000);
//{
 // number = number/10;
 // return number;
//}
//{
 // number = number%10;
 // return number;
//}
//Console.WriteLine(remainsDigit(number));

//int RemainsDigit = remainsDigit(number);
//if (RemainsDigit>0)
//{
  //
//}
//else
//{
  //Console.WriteLine("третьей цифры нет");
//}


//}
//else {
//  Console.WriteLine("третьей цифры нет");
//}

//
//RemainsDigit(number);
