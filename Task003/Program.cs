//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


void day(int number)
{
    switch (number)
    {
        case 1: Console.WriteLine("Понедельник - рабочий день"); break;
        case 2: Console.WriteLine("Вторник - рабочий день"); break;
        case 3: Console.WriteLine("Среда - рабочий день"); break;
        case 4: Console.WriteLine("Четверг - рабочий день"); break;
        case 5: Console.WriteLine("Пятница - рабочий день"); break;
        case 6: Console.WriteLine("Суббота - выходной день"); break;
        case 7: Console.WriteLine("Воскреснье - выходной день"); break;
    }
}

Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8)
{
    day(num);
}
else
{
    while (num > 7)
    {
        num = num - 7;
    }
    day(num);
}