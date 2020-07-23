using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input coordinates in format like: 23.8976,12.3218");
            string lineCoordinate; // Строка для хранения неформатированных координат
            while ((lineCoordinate = Console.ReadLine()) != null) // Считываем построчно строку с координатами из входящего потока <
            {
                Console.WriteLine(Сoordinate.formatCoordinate(lineCoordinate)); // Преобразуем к желаемому формату координат
            }
        }
    }
}
