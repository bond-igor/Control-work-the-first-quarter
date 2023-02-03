// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

//___МЕТОДЫ___

//запрос данных у пользователя
string ReadData(string msg)
{
    //выводим сообщение
    Console.WriteLine(msg);
    //считываем данные
    return Console.ReadLine() ?? "0";//возвращаем значение
}

// создаем массив из полученных данных
string [] CreatArray(string stroka)
{
string[] inputArray = stroka.Split(' '); // элементы массива разделяются пробелом
return inputArray; 
}

// метод находит элементы массива число символов в которых меньше или равно трём
void FillExitingArray(string[] inputArray, string[] exitingArray)
{
    int count = 0;                                  //объявляем дополнительную переменную, чтобы записать значения в новый массив по порядку
    for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length < 4)
        {
        exitingArray[count] = inputArray[i];
        count++;
        }
    }
}

//вывод результата
void PrintArray(string[] array)
{
    Console.WriteLine("Строки в которых 3 и менее символов:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//___ПРОГРАММА___

string stroka = ReadData("Введите массив символов через пробел:"); //запрос данных
string[] inputArray = CreatArray(stroka);                          //создаем из данных массив 
string[] exitingArray = new string[inputArray.Length];             //создаем второй массив, равный по длинне первому 
FillExitingArray(inputArray, exitingArray);                        //заполняем второй массив значениями 
Console.WriteLine();
PrintArray(exitingArray);                                          //печатаем получившийся массив 
