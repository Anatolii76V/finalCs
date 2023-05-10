/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо
равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При
решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Примеры:
["hello", "2", "world", ":-"] -> ["2", ":-"]
["Russia", "Kazan"] -> [] 
*/

Console.Write("Введите размер массива строк: ");
int arrayLength = Convert.ToInt32(Console.ReadLine()); 
string[] inputArray = new string[arrayLength];

// Заполнение массива строк
for (int i = 0; i < inputArray.Length; i++)
{
    Console.Write("Введите элемент массива строк: ");
    string elem = Console.ReadLine().Replace(" ", ""); // Удаляем пробелы
    if (elem != "") inputArray[i] = elem;
    else i--;
}

Console.Write("[{0}]", string.Join(", ", inputArray));

// Функция для получения массива строк с длиной <= maxLength
string[] GetStringsByMaxLength(string[] array, int maxLength)
{
    int count = 0;
    int tempIndex = 0;
    string[] emptyArray = new string[0];

    // Подсчет количества элементов, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= maxLength) count++;
    }

    if (count == 0) return emptyArray;

    string[] resultArray = new string[count];
    
    // Заполнение результирующего массива элементами, удовлетворяющими условию
    for (int j = 0; j < array.Length || tempIndex < maxLength; j++)
    {
        if (array[j].Length <= maxLength)
        {
            resultArray[tempIndex] = array[j];
            tempIndex++;
        } 
    }

    return resultArray;
}

Console.WriteLine($" -> [{string.Join(", ", GetStringsByMaxLength(inputArray, 3))}]");
