/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*
Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());

if (x == 1){
    Console.WriteLine("x > 0, y > 0");
} else if (x == 2) {
    Console.WriteLine("x < 0, y > 0");
} else if (x == 3) {
    Console.WriteLine("x < 0, y < 0");
} else if (x == 4) {
    Console.WriteLine("x > 0, y < 0");
} else {
    Console.WriteLine("Вы ввели не верную четверть");
}*/
// все работает, ок
// в чат решение кинуть?

Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt16(Console.ReadLine());

if (num < 0 && num > 4) Console.WriteLine("Введите заново.");
    

else
{
    switch (num)
    {
        case 1:
            Console.WriteLine("1 четверьть, диапазон X∈[0;+∞), Y∈[0;+∞)");
            break;
        case 2:
            Console.WriteLine("2 четверьть, диапазон X∈(-∞;0], Y∈[0;+∞)");
            break;
        case 3:
            Console.WriteLine("3 четверьть, диапазон X∈(-∞;0], Y∈(-∞;0]");
            break;
        case 4:
            Console.WriteLine("4 четверьть, диапазон X∈[0;+∞), Y∈(-∞;0]");
            break;
        default:
            Console.WriteLine("Ввели не верное число");    
            break;
    }
}
