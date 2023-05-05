# Описание решения

Для начала программы необходимо создать массив строк, который можно задать на старте выполнения алгоритма или ввести с клавиатуры. Для ввода с клавиатуры используем метод Console.ReadLine(), который возвращает строку, введенную пользователем.

Затем проходим по элементам массива строк и проверяем длину каждой строки. Если длина строки меньше или равна 3 символам, добавляем ее в новый массив. Для этого можно использовать цикл for и условную конструкцию if.

После проверки всех элементов и формирования нового массива строк выводим его на экран. Для вывода на консоль используем метод Console.WriteLine(), который выводит переданную ему строку и переводит курсор на новую строку.

Для реализации этой задачи не требуется использование коллекций, так как задание выполняется исключительно с помощью массивов.

# Логика алгоритма:

1. Создать и инициализировать массив строк.
2. Создать новый массив строк.
3. Пройти по исходному массиву строк с помощью цикла.
4. Для каждой строки проверить её длину.
5. Если длина строки меньше или равна 3 символам, добавить её в новый массив строк.
6. По завершении цикла вернуть новый массив строк с отобранными строками.