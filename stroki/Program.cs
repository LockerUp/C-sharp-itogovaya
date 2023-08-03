// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

System.Console.WriteLine("Укажите желаемую длину массива: ");
int size = int.Parse(Console.ReadLine());
string[] arr = CreateAndFillArray();
int newSize = ChoiceSizeNewArray(arr);
string[] newArr = CreateAndFillNewArray(arr, newSize);

System.Console.WriteLine($"[{string.Join(", ", arr)}] -> [{string.Join(", ", newArr)}]");


string[] CreateAndFillArray()
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int ChoiceSizeNewArray(string[] array)
{
    string str = " ";
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        str = array[i];
        if (str.Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] CreateAndFillNewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    string str = " ";
    for (int i = 0; i < array.Length; i++)
    {
        str = array[i];
        if (str.Length <= 3)
        {
            newArray[j] = str;
            j++;
        }
    }
    return newArray;
}