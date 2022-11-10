// апишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе. Через строку решать нельзя.

//452 -> 11
//82 -> 10
//9012 -> 12

int digitSum(int number)
    {
        int sum = 0, m;
        while (number > 0)
        {
            m = number % 10;
            sum = sum + m;
            number = number / 10;
        }
        return sum;
    }
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("результат: "+ digitSum(number));