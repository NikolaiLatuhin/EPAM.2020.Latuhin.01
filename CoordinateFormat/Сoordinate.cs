using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateFormat
{
    /// <summary>
    /// Класс для работы с преобразованием координат
    /// положения объекта к нужному формату
    /// </summary>
    public static class Сoordinate
    {
        /// <summary>
        /// Функция для преобразования координат к желаемому формату.
        /// Пример:
        /// Было: 23.8976,12.3218
        /// Станет: X: 23,8976 Y: 12,3218
        /// </summary>
        /// <param name="inputCoordinates">Входная строка содержащая координаты без форматирования</param>
        /// <returns>Возвращает отформатированные координаты</returns>
        public static string formatCoordinate(string inputCoordinates)
        {
            string[] coordinates = inputCoordinates.Split(','); // Выделим строки с отдельными координатами для X и Y
            const int numberCoordinates = 2; // Каждая строка содержит количество координат равное 2 (X и Y)
            string result; // Строка содержащая результат функции по преобразованию координат к желаемому формату

            if (coordinates.Length == numberCoordinates) // Проверка на количество координат в строке
            {
                if (Decimal.TryParse(coordinates[0], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal x) // Проверка на корректность введенных числовых значений
                &&  Decimal.TryParse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal y))// для координат X и Y
                {
                    result = $"X: {x} Y: {y}";
                }
                else
                {
                    result = $"Incorrect input data or format coordinates. Inputted data {inputCoordinates}"; // Введены значения отличающиеся от числовых
                }
            }
            else
            {
                result = $"Incorrect input number of coordinates. Inputted data {inputCoordinates}"; // Количество координат в строке некорректное
            }
            return result;
        }
    }
}
