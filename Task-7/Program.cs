//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

 int myPow(int a, int b)
    {
        int number = a;
        for(int i = 0; i < b-1; i++)
        {
            number *= a;
        }
        return number;
    }
    Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень");
int number2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("результат: "+ myPow(number,number2));