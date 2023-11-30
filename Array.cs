using System;


class ArrayOperations

{

    public static void ArrSum(int[] a)
    {
        int sum=0;


        foreach (int index in a)
        {
            sum += index;

        }
        Console.WriteLine("\n сумма {0}", sum);
    }

   public  static void ArrMidle(int[] a)
    {
        double sum = 0;

        foreach (int index in a)
        {
            sum += index;


        }
        sum /= a.Length;

        Console.WriteLine("\n среднее значение элементов массива {0: 0.0}", sum);

    }
   public static void ArrPlusMinus(int[] a)
    {

        int plus = 0;
        int Minus = 0;
        foreach (int index in a)
        {
            if (index > 0)
            {
                plus += index;
            }
            if (index < 0)
            {
                Minus += index;

            }

            
        }
        Console.WriteLine("\n сумма положительных {0} Сумма отрицательных {1}", plus, Minus);

    }

    static void Main()
    {

        Console.WriteLine("Введи размер массива");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Заполните массив случайными числами от?");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Заполните массив случайными числами до?");
        int b = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        int[] myArr = new int[i];

        //заполнение случайными числами 
        for (int n = 0; n < i; ++n)
        {

            myArr[n] = rnd.Next(a, b);
        }



        // Вывод списка элементов массива
        foreach (int index in myArr)
        {
            Console.Write(" {0}", index);

        }

        ArrSum(myArr);
        ArrMidle(myArr);
        ArrPlusMinus(myArr);

        Console.ReadKey();
    }

  
}