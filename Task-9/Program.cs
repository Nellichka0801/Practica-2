//  Напишите программу, которая задаёт массив из 8 целых чисел 
//с клавиатуры и далее выводит массив на экран в одну строку.


void ArrayFromInput()
    {
        int[] arr = new int[8];
        for (int i = 0; i < 8; i++) {
            Console.WriteLine("Введите число массива");
            arr[i] = int.Parse(Console.ReadLine());
        }
        string s = "";
        for(int i = 0; i < arr.Length; i++)
        {
            s += arr[i];
        }
        Console.WriteLine("Результат: "+ s);
    }
    
ArrayFromInput();