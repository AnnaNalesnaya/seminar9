// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void ShowNaturalRow(int number)
{
    if (number <= 0)
    {
        return;
    }
    System.Console.WriteLine(number);
    ShowNaturalRow(number - 1);

}
int number = Prompt("введите число-> ");
System.Console.WriteLine();
ShowNaturalRow(number);

