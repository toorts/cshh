// //* Вид 1

// void Method1()
// {
//     Console.WriteLine("Hello There");
// }

// Method1();

// //* Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// string message = "Hello Hello";
// Method2(message);
// // Или
// Method2("Hello World");
// ///
// Console.WriteLine();
// ///
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21("Hello Harry", 4);
// // Или
// Method21(msg: "Harry", count: 4);
// // Или
// Method21(count: 4, msg: "Hello");

// //* Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();

// Console.WriteLine(year);

//* Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }

//     return result;
// }


// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method4(4, "ewrq");
// Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}