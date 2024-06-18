using System.Drawing;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleDZ5
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Задача 1");
            ListBook list1 = new ListBook(2);

           

            list1 [0] = new Book ("Три мушкетера", "А. Дюма");
            list1[1] = new Book("Ледокол", "В. Суворов");

            Book book1 = new Book("Чайка", "А. Чехов");
            list1.AddBook(list1, book1);
            list1.Print();

            Book book2 = new Book("Три мушкетера", "А. Дюма");

            list1.AddBook(list1, book2);
            list1.Print();               // Не добавляет, т.к. уже есть данная книга

           Console.WriteLine (list1.Search("Ледокол"));

            Console.WriteLine("Задача 2");
            Matrix v = new (3,5); // Двумерный массив. Заполняем, выводим

            Random random2 = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    v[i, t] = random2.Next(0, 9);
                    Console.Write(v[i, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");

            Matrix v1 = new(3, 5); // Двумерный массив. Заполняем, выводим
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    v1[i, t] = random2.Next(5, 12);
                    Console.Write(v1[i, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Сложение матриц");
            Matrix b  = v + v1;
            b.Print();
            Console.WriteLine("--------------------");
            Console.WriteLine("Умножение матриц");
            Matrix с = v * v1;
            с.Print();
            Console.WriteLine("--------------------");
            Console.WriteLine("Вычитание матриц");
            Matrix l = v - v1;
            l.Print();
            Console.WriteLine("--------------------");
            Console.WriteLine("Умножение матрицы на число");
            Matrix p = v * 6;
            p.Print();










        }


    }
}
