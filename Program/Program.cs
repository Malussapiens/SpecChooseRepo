//Задача: Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] strings)
{
    Console.Write("[");
    if (strings.Length > 0)
    {
        Console.Write($"\"{strings[0]}\"");
        for (int i = 1; i < strings.Length; i++)
        {
            Console.Write($", \"{strings[i]}\"");
        }
    }
    Console.Write("]");
}

string[] StringCount(string[] strings, int stringLength)
{
    int j = 0;
    string[] result = new string[j];
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= stringLength)
        {
            Array.Resize(ref result, j + 1);
            result[j] = strings[i];
            j++;
        }
    }
    return result;
}

string[] strings = new string[] { "Hello", "2", "world", ":-)" };
int stringLength = 3;
PrintArray(StringCount(strings, stringLength));