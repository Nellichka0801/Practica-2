//  Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа. 
//456 -> 5
//782 -> 8
//918 -> 1

int GenerateRandomNumber()
{
    return new Random().Next(100,1000);
}
int randomNumber = GenerateRandomNumber();
Console.WriteLine ("Рандомное число " + randomNumber);

int SecondDigit(int randomNumber)
{
    int dozens = randomNumber/10;
    int secondDigit = dozens%10;
    return secondDigit;
}

Console.WriteLine("Вторая цифра из числа = :" + SecondDigit(randomNumber));



