/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
int[] DataEntry()
{
    System.Console.WriteLine("Введите числа с клавиатуры: ");
    string[] temp = Console.ReadLine().Split(" ").ToArray();
    int[] nums = new int[temp.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        nums[i] = Convert.ToInt32(temp[i]);
    }
    return nums;
}

void PrintCountPositiveNums(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
            count++;
    }
    System.Console.WriteLine(count);
}
PrintCountPositiveNums(DataEntry());