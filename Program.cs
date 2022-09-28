string[] firstarray = new string[8] {"mail", "auto", "999", "q", "24567", "geekbrains", "-698", "-10"};
string[] secondarray = new string[firstarray.Length];

Console.WriteLine();
Length0fThreeArray(firstarray, secondarray);
Console.WriteLine("Введенный массив:");
OutputArray(firstarray);
Console.WriteLine();
Console.WriteLine("Получившийся массив:");
OutputArray(secondarray);
Console.WriteLine();

void Length0fThreeArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void OutputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}