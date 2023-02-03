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
string [] CreatArray(string stroka)
{
string[] inputArray = stroka.Split(' ');
return inputArray; 
}

void FillExitingArray(string[] inputArray, string[] exitingArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length <= 3)
        {
        exitingArray[i] = inputArray[i];
        count++;
        }
    }
}

//вывод результата
void PrintArray(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//___Программа___
string stroka = ReadData("Введите массив символов через пробел.");
string[] inputArray = CreatArray(stroka);
string[] exitingArray = new string[inputArray.Length];
FillExitingArray(inputArray, exitingArray);
Console.WriteLine();
PrintArray(exitingArray);
