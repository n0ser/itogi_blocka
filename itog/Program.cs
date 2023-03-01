int n = 10;
Console.WriteLine($"В заданном массиве всего {n} элементов");

string[] array = new string[n];
array[0] = "five";
array[1] = "three";
array[2] = "tree";
array[3] = "six";
array[4] = "nine";
array[5] = "3";
array[6] = "how";
array[7] = "5";
array[8] = "one";
array[9] = "gggg";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Внимание, ваш исходный массив:");
PrintArray(array);

string[] arrayLessThanThree(string[] array)
{
    int lengthOfNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lengthOfNewArray++;
    }

    string[] newArray = new string[lengthOfNewArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

Console.WriteLine();
Console.WriteLine($"Внимание, ваш новый массив коротышей:");
PrintArray(arrayLessThanThree(array));