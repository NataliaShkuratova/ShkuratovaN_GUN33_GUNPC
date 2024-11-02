using System.Text;
namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача А
            //Задание 1
            int[] FibonacciNumbers = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //Вывод Чисел Фибоначчи
            //Console.WriteLine("FibonacciNumbers: ");
            //Array.ForEach(FibonacciNumbers, Console.WriteLine);

            //Задание 2
            string[] Months = new string[12]
            { "January", "February", "March", "April", "March", "June", "July", "August","September", "October", "November", "December"};

            //Вывод списка месяцев
            //Console.WriteLine("Months: ");
            //Array.ForEach(Months, Console.WriteLine);

            //Задание 3
            int[,] DegreeNumbers = new int[3, 3]
            {
            { 2, 3, 4 },
            { 4, 9, 16 },
            { 8, 27, 256 }
            };

            //Вывод заданного элемента массива
            //int result0 = DegreeNumbers[1, 2];
            //Console.WriteLine(result0);


            //Задание 4
            double[][] JaggedArray = new double[3][];
            JaggedArray[0] = new double[5] { 1, 2, 3, 4, 5 };
            JaggedArray[1] = new double[2] { Math.E, Math.PI };
            JaggedArray[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            //Вывод заданного элемента массива
            //double result1 = JaggedArray[2][0];
            //Console.WriteLine(result1);

            //Задача Б
            //Задание 5
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, array2, 3);

            //вывод результата копирования
            //Console.WriteLine("the result of copying array elements: ");
            //Array.ForEach (array2, Console.WriteLine);


            //Задание 6
            Array.Resize(ref array, array.Length*2);

            //Вывод результата увеличения в 2 раза
            //Console.WriteLine("The result of increasing the array by 2 times");
            //Array.ForEach(array, Console.WriteLine);
        }
    }
}
