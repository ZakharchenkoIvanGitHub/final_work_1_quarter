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
        if (item.Length <= 3)
        {
            newArray = AddArray(array:newArray, data:item);
        }
    }
    return newArray;
}

//Добавляет элемент в массив
string[] AddArray(string[] array, string data)
{
    Array.Resize(ref array, array.Length+1);
    array[array.Length]=data;
    return array;
}

//Печатает одномерный массив
void Print1DArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

