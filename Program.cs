
string[] inputArray = EnterArray(); //  Ввводим массив через пробел
string[] outputArray = PrintExitArray(inputArray, 3); // Готовый наш новый масив
Console.WriteLine($"[{string.Join(", ", inputArray)}] --> [{string.Join(", ", outputArray)}]"); // Выводим массив сперва старый массив, затем новый

string[] EnterArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int FindLengthArray(string[] input, int n) // Поиск длинны нового массива
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}


string[] PrintExitArray(string[] input, int n)  // Проверяем длину массива[i] <= 3, и помещаем в новый массив 
{
    string[] output = new string[FindLengthArray(input, n)]; // Вносим длинну массива
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];   // записываем в массив под индексом[j] значение массива под индекс[i]
            j++;                    // прибовляем +1 к индексу массива для записи в последующий массив
        }
    }

    return output; // возвращаем массив
}

