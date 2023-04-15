

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

//Копирование массива
int[] Copy1DArray(int[] arr)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

int len = 10; // длина массива
int top = 100; // верхняя граница случайных чисел
int but = 1; // нижняя граница случайных чисел

int[] arr1 = Gen1DArray(len, top, but); // заполнение массива
Print1Darray(arr1);

int[] arr2 = Copy1DArray(arr1); // создание копии массива
Print1Darray(arr2);
