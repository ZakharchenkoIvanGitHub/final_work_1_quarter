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
        if (str.Length <= 3)
        {
            newArray = AddArray(array: newArray, data: str);
        }
    }
    return newArray;
}

// Добавляет элемент в массив.
string[] AddArray(string[] array, string data)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = data;
    return array;
}

// Печатает одномерный массив.
void Print1DArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (!String.IsNullOrEmpty(array[i]))
            Console.Write(array[i]);
        if (i < array.Length - 1 && !String.IsNullOrEmpty(array[i + 1]))
            Console.Write(", ");
    }
}

//Основная прграмма
string[] array = SeparatedArray(ReadData("Введите массив из строк разделяя элементы запятыми"));
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
Print1DArray(array);
