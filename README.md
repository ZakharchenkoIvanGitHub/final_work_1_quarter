# Итоговая проверочная работа
## Задача
Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа.

## Решение

Программа выполнена на языке C#

Метод **ReadData** запрашивает данные. Пользователь вводит массив строк раздеенных запятыми. Метод возвращеет массив введенных данных.

Массив передается в метод **SeparatedArray**. В методе создается пустой массив *newArray*. Даее в цикле *foreach* у каждого элемента массива удаляются все начальные и конечные символы пробела. Далее, если выполняется условие: длина строки меньше либо равна 3 и строка не является пустой, элемент вместе с массивом *newArray* передаются в метод **AddElementArray** который возвращает массив с добавленным в коней элементом. После выполения всех циклов инструкции *foreach* метод **SeparatedArray** возвращает массив из строк, длина которых меньше либо равна 3 символа.

Далее новый массив передается в метод Print1DArray, где выводится на печать.

