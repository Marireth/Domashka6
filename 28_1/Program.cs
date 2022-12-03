/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int[] GetUserArray(int length, int start, int end)
{
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Внимание! Элементы массива вводятся вручную!");
    Console.ResetColor();
    Console.Write("Введите размер массива: ");
    
    length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
                Console.Write($"Введите {i}-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;

}
void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ResetColor();
}

int NumberGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] newArray = GetUserArray(20, -999, 999);
Console.WriteLine();
PrintArray(newArray);
int countNumberMoreZero = NumberGreaterZero(newArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Количество чисел больше 0, введенных пользователем = {countNumberMoreZero}");
Console.WriteLine();
Console.ResetColor();