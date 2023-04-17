using System;

class Program {
    static void Main(string[] args) {
        int[,] arr = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}}; // исходный массив

        int minSum = int.MaxValue; // переменная для хранения минимальной суммы
        int minRow = -1; // переменная для хранения номера строки с минимальной суммой

        // перебираем каждую строку массива
        for (int i = 0; i < arr.GetLength(0); i++) {
            int rowSum = 0; // переменная для хранения суммы элементов текущей строки
            for (int j = 0; j < arr.GetLength(1); j++) {
                rowSum += arr[i, j];
            }
            if (rowSum < minSum) { // если сумма текущей строки меньше минимальной
                minSum = rowSum; // обновляем минимальную сумму
                minRow = i; // обновляем номер строки с минимальной суммой
            }
        }

        // выводим строку с наименьшей суммой элементов
        Console.Write("Строка с наименьшей суммой элементов: ");
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[minRow, j] + " ");
        }
    }
}
