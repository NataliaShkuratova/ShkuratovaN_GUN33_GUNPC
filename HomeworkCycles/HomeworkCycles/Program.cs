using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;
namespace HomeworkCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            int[] FibonacciNumbers = new int[10] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            foreach (int element in FibonacciNumbers)
            {
                Console.Write($" {element} ");
            }

            //Мозгами понимаю, что как-то можно заставить через команду считать и сами числа, но слишком маленькие знания в области программирования и непонимание, что именно искать, так и не дали ничего такого выдумать(


            //Задание 2

            for (int Number = 2; Number <= 20; Number++)
            {
                if (Number % 2 == 0)
                    Console.WriteLine(Number);
            }

            //Задание 3

            for (int FirstLine = 1; FirstLine <= 5; FirstLine++)
            {
                for (int SecondLine = 1; SecondLine <= 5; SecondLine++)
                {
                    Console.Write($" {FirstLine * SecondLine} \t");
                }
                Console.WriteLine();
            }

            //Задание 4

            string Password = "qwerty";

            do
            {
                Console.WriteLine("Please enter the password: ");
            }

            while (Password != Console.ReadLine());
            Console.WriteLine("The correct password!");

            //Хотелось извернуться и сделать, чтобы было сообщение в случае неправильного пароля, но оно не работает по-человечески, хотелось бы узнать, можно ли это сделать. Мои невразумительные попытки:

            //string Password = "qwerty";
            //do
            //{
            //    Console.WriteLine("Please enter the password: ");

            //    if (!Int32.TryParse(Console.ReadLine(), out var qwerty))
            //      или
            //    if (!Char.TryParse(Console.ReadLine(), out var qwerty)) //В случае с Int32 не выдает ошибку на ввод чисел, поэтому нашла Char. Хотя не работает он так же, как и Int. Upd: Поняла, уже когда просматривала в репозитории: оба варианта неправильные, потому что один "не-число", а второй "не-символ"?
            //    {
            //        Console.WriteLine("Wrong password!");
            //        continue;
            //    }
            //}
            //while (Password != Console.ReadLine());
            //Console.WriteLine("The correct password!");
        }
    }
}
