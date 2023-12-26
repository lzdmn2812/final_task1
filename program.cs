using System.Xml.XPath;

string[] createArray()
{
    Console.WriteLine("Введите кол-во строк: ");
    int numberOfStrings = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[numberOfStrings];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите текст {i + 1} строки: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string[] Filter(string[] arrayOfStr)
{
    string[] resultArray = new string[arrayOfStr.Length];
    int countOfEmptyStr = 0;
    for (int i = 0; i < arrayOfStr.Length; i++)
    {
        if (arrayOfStr[i].Length < 4)
        {
            resultArray[i] = arrayOfStr[i];
        }
        else
        {
            countOfEmptyStr++;
        }

    }
    resultArray = DeleteEmptyElements(resultArray, countOfEmptyStr);
    return resultArray;

}

string[] DeleteEmptyElements(string[] array, int count)
{
    string[] resultArray = new string[array.Length - count];
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            resultArray[number] = array[i];
            number++;
        }

    }

    return resultArray;
}

string[] array = createArray();
Console.WriteLine();
Console.WriteLine("Ваш массив:");
printArray(array);
Console.WriteLine();
string[] filterArray = Filter(array);
Console.WriteLine("Отфильтрованный массив: ");
// string[] FilterArray= array.Where(a => a.Length <= 3).ToArray(); коллекции
printArray(filterArray);