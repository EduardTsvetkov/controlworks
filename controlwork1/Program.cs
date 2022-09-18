/// <summary>
/// Запрос у пользователя на ввод информации, проверка правильности 
/// </summary>
/// <param name='request'>Запрос к пользователю на ввод информации</param>
/// <returns>Целое число, введенное пользователем</returns>
int GetIntInResponce(string request)
{
    string answer = String.Empty;
    while (true)
    {
        Console.Write(request);
        answer = Console.ReadLine();
        if (int.TryParse(answer, out int result))
        {
            return result;
        }
        Console.WriteLine("Вы ввели не целое число. ");
    }
}

/// <summary>
/// Чтение массива строк из текстового файла 
/// </summary>
/// <param name='path'>Имя существующего текстового файла</param>
/// <returns>Массив строк</returns>
string[] GetArrayFromFile(string path)  // читаем все строки файла в массив
{
    Console.WriteLine($"Читаем файл {path}");
    string[] lines = File.ReadAllLines(path);
    return lines;
}

/// <summary>
/// Вывод массива строк в консоль 
/// </summary>
/// <param name='inputArray'>Массив строк</param>
/// <returns></returns>

void PrintStringArray(string[] inputArray)
{
    foreach (string itemArr in inputArray)  // для каждого элемента inputArray, который передается в переменную itemArr
    {
        Console.Write($"{itemArr} ");
    }
}



Console.Clear();
Console.Write("Введите имя файла (например, test.txt): ");
string fileName = Console.ReadLine();
while (!File.Exists(fileName))   // проверяем открывается ли файл
{
    Console.WriteLine($"Файл {fileName} не существует.");
    Console.Write("Введите имя файла: ");
    fileName = Console.ReadLine();
}

string[] strArr = GetArrayFromFile(fileName);

Console.WriteLine();
Console.WriteLine("Полученный массив: ");
PrintStringArray(strArr);
Console.WriteLine();
Console.WriteLine();
