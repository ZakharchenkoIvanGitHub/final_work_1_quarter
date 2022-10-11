// Запрос данных пользователяю, принимает строку заголовок.
// Возврашает массив введенных слов.
string [] ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    return (Console.ReadLine() ?? "0").Split(",");
}