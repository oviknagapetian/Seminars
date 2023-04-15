// Задача №35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод печати одномерного массива
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}


int ElmInRange(int[] arr, int min, int max)
{
    int res=0;
    for(int i=0; i<arr.Length; i++)
    {
        if (arr[i]>min&&arr[i]<max)
        {
            res++;
        }
    }
    return res;
}

int[] arr = Gen1DArray(123,1000,0);
Print1Darray(arr);
int res = ElmInRange(arr, 10, 99);
Console.WriteLine("Элементов, лежащих в границах [10;99]: "+ res);