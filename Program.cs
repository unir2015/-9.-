using System;
// ДЗ


// Задача 64: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end)
{
   
    if (start == end) return start.ToString();
    
    return (start + "\t" + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(M, N));



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///



// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30





Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


int SumNumbers (int start, int end)
{
    
    if (start == end ) return start;
    if (0 == end ) return 0;
    // if (start == 0 ) return 0;  // надо или нет , если плюсовать на ноль прибавки не будет  тотже ответ что с цифрой 1
    if (start > end  ) return 0;
    
    return    start + SumNumbers(start + 1 , end);
}


Console.WriteLine(SumNumbers(M, N));











// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




Console.Write("Введите число n: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число m: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            
            static int Akkerman(int n, int m)
            {
                if(n == 0) return m + 1;
                if(m == 0) return Akkerman(n - 1, 1);
                return Akkerman(n - 1, Akkerman(n, m - 1));
                
            }
            
System.Console.WriteLine(Akkerman(m, n));