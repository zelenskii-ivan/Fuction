


void zadacha10()
{

    /* Напишите программу, которая принимает на вход трёхзначное число и 
    на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1 */

    Console.WriteLine("число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"число={(num / 10) % 10}");
}
 
 
void zadacha13()
{
 /* Задача 13: Напишите программу, которая с помощью деления выводит 
 третью цифру заданного числа или сообщает, что третьей цифры нет.
 645 -> 5
 78 -> третьей цифры нет
 32679 -> 6 */



    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    string numberS = Math.Abs(number).ToString();
    Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" :
    "${numberS} -> третьей цифры нет");

}


void zadacha15()
{
 /*Задача 15: 
 Напишите программу, которая принимает на вход цифру, 
 обозначающую день недели, и проверяет, является ли этот день выходным.
 6->да 7->да 1->нет*/

 Console.WriteLine("введите цифру>день недели>узнать = выходной");
 int dayNumber = Convert.ToInt32(Console.ReadLine());
 void ChoiceDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine(" это не день недели");
    }
    else
    Console.WriteLine(" не выходной");
}
 ChoiceDay(dayNumber);



}
 //zadacha10();
 //zadacha13();
 //zadacha15();


