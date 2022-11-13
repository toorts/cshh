//* string matrix

// string[,] table = new string[2, 5];

// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"--{table[rows, columns]}--");
//     }
// }


//* int matrix

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }

//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);

// Console.WriteLine();

// FillArray(matrix);
// PrintArray(matrix);


//* recursion

// int Factorial(int n)
// {
//     if (n == 1)
//         return 1;        // 1! = 1 / 0! = 1
//     else
//         return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(3));

//* fibonacci 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}