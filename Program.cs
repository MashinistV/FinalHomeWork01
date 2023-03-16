//Написать программу, которая из имеющегося массива строк 
//формируется массив из строк, длина которых меньше либо 
//равна 3 символа. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма.

bool isWork = true;

while(isWork)
{
    Console.WriteLine("Enter array manualy? (y/n)");
    
    switch (Console.ReadLine())
    {
        case "y":
        {
            Console.WriteLine("Enter strings. For ending put \"Enter\".");
            string[] array = ReadArray();
            Console.WriteLine("Entered array:");
            PrintArray(array);
            Console.WriteLine("Sorted array:");
            PrintArray(SortArray(array));
            isWork = false;
            break;
        }

        case "n":
        {
            Console.WriteLine("Entered array:");
            string[] array = {"hello", "2", "world", ":-)"};
            PrintArray(array);
            Console.WriteLine("Sorted array:");
            PrintArray(SortArray(array));
            isWork = false;
            break;
        }
    }
}

string[] ReadArray()
{
    string gb = "gb";
    string[] array = new string[0];

    while(gb.Length > 0)
    {
        gb = Console.ReadLine();
        string[] temp = new string[array.Length+1];

        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }

        temp[array.Length] = gb;
        array = new string[temp.Length];

        for (int j = 0; j < temp.Length; j++)
        {
            array[j] = temp[j];
        }
    }

    string[] newarray = new string[array.Length-1];

    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = array[i];
    }

    return newarray;
}

void PrintArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }

    Console.WriteLine($"\"{array[array.Length-1]}\"]");
}

string[] SortArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    int j = 0;
    string[] newarray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }

    return newarray;
}