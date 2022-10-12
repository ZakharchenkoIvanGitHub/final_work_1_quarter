//==========================================
//Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше либо равна 3 символа.
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Возврашает массив введенных слов.
string[] ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    return (Console.ReadLine() ?? "0").Split(",");
}

// Возвращает массив с элементами длина которых меньше либо равна 3 символа.
string[] SeparatedArray(string[] array)
{
    string[] newArray = Array.Empty<string>();
    foreach (string item in array)
    {
        string str = item.Trim();
        if (str.Length <= 3 && !String.IsNullOrEmpty(str))
        {
            newArray = AddElementArray(array: newArray, data: str);
        }
    }
    return newArray;
}

// Добавляет элемент в массив.
string[] AddElementArray(string[] array, string data)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = data;
    return array;
}

// Печатает одномерный массив.
void Print1DArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//Основная прграмма
string[] array = SeparatedArray(ReadData("Введите массив из строк разделяя элементы запятыми"));
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
Print1DArray(array);
