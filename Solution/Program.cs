
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
