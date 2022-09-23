/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();
Console.Write("Введите число от 1 до N: ");
int n = int.Parse(Console.ReadLine());
int count = 1;

if (n <= 0) Console.WriteLine("Вы ввели не верное число");

while (count <= n) {
    Console.WriteLine(count * count);
    count++;
}
/*
Console.Clear();

Console.WriteLine("Введите N: ");

int num = int.Parse(Console.ReadLine ());

for (int i =1; i<=num; i++)
Console.Write(Math.Pow(i, 2)+" ");
*/