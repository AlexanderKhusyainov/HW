
Console.Clear();

string[] array1 = new string[6] {"cat","no","1","feel","1984","good"};
string[] array2 = new string[array1.Length];

void SortingArray(string[] array1, string[]array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}
void PrintSortingArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if(null != array[i])
        {   
            Console.Write($"{array[i]},");
        }
    }
    Console.Write($"]");
}

Console.WriteLine($"Пользователь, программа формирует массив строк, длина которых меньше или равна 3 символа");
Console.WriteLine();
Console.Write($"Было ->");
SortingArray(array1,array2);
PrintSortingArray(array1);
Console.Write($"  Стало ->");
PrintSortingArray(array2);
Console.WriteLine();