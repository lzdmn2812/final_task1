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


string[] array = createArray();
Console.WriteLine();
Console.WriteLine("Ваш массив:");
printArray(array);