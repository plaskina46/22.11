// See https://aka.ms/new-console-template for more information
int[] nums = new int[6];
try
{
    Console.WriteLine("До генерирования исключения.");
    for (int i = 0; i < 10; i++)
    {
        nums[i] = i;
        Console.WriteLine("nums[(0)]: {1}", i, nums[i]);
    }
    Console.WriteLine("He подлежит выводу");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Индекс вышел за границы массива!");
}
Console.WriteLine("После блока перехвата исключения.");