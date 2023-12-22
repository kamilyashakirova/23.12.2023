using System;
class Program
{
    // добор баллов 2 задача. написать функцию, которая принимает массив строк в качестве аргумента и возвращает отсортированный массив, содержащий те же строки, отсортированные от самой короткой к самой длинной.
    static void Main(string[] args)
    {
        string[] arr = { "Telescopes", "Glasses", "Eyes", "Monocles" };
        string[] sorted = SortByLength(arr);
        Console.WriteLine("написать функцию, которая принимает массив строк в качестве аргумента и возвращает отсортированный массив, содержащий те же строки, отсортированные от самой короткой к самой длинной.");
        Console.WriteLine("исходный массив: {0}", arr);
        Console.WriteLine("отсортированный массив: {0}", string.Join(", ", sorted));
    }
    /// <summary>
    /// метод для сортировки
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    static string[] SortByLength(string[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i].Length > arr[j].Length)
                {
                    string t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
        }
        return arr;
    }
}