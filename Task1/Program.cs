// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//  Программа запрашивает у пользователячисло, вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа через запятую: ");     //1. Пользователь вводит число
int[] numbers = StringProcessing(Console.ReadLine());    //2 передаём в функцию StringProcessing введёное значение 3. Передаем введёные значения пользователя numbers[index], которые были обработаны в функции StringToNum, в массив numbers
PrintArray(numbers);    //4. распечатываем переданный массив numbers
CountingPositiveNumbers(numbers);       // 5. Функция CountingPositiveNumbers принимает на обработу массив numbers

void CountingPositiveNumbers(int[] Positiv)       // 5. Функция посчитайте, сколько чисел больше 0 ввёл пользователь.
{
int PositiveNumbers = 0;

for (int i = 0; i < Positiv.Length; i++)
{
    if (Positiv[i] > 0)
    {
        PositiveNumbers++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {PositiveNumbers}");
}


int[] StringProcessing(string input)     // 2. Функция принимает на вход строку и заполнения массив
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)      // цикл заполняет массив, с разделителем ','
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];        // выделяем место в памяти для массива
    int index = 0;

    for (int i = 0; i < input.Length; i++)      // цикл прохождению по элементам строки
    {
        string temp = " ";       //переменной temp присваиваем пустую строку

        while (input [i] != ',')        // цикл делай пока индекс массива input не равен "," перебор массива
        {
        if(i != input.Length - 1)       // цикл если элемнт не равен длине массива
        {
            temp += input [i].ToString();  // в переменную temp складывается значения массива input
            i++;
        }
        else        // если i равно input.Length - 1, то 
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)        // 4. Функция распечатывание массива на экран
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}