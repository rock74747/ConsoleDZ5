using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleDZ5
{
    public class ListBook 
    {
        public Book[] Books;
        

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < Books.Length)
                {
                    return Books [index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                Books [index] = value;
            }
        }
        public ListBook (int size)
        {
            Books = new Book [size];
        }
        public int Length ()
        {
             return Books.Length; 
        }

        public void Print() // Вывод книг 
        {
            
            for (int i = 0; i < Books.Length; i++)
                Console.WriteLine(Books[i].ToString());
        }

        // Добавление книги      
        public ListBook AddBook(ListBook collection, Book book)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i]==book)    // проверка на наличие добавляемой книги в коллекции
                {
                     return collection;
                }
                else break;
            }
            Book[] tmp = new Book[collection.Length () + 1]; 
            for (int i = 0; i < collection.Length(); ++i) 
            tmp[i] = collection[i];
            tmp[collection.Length()] = book; 
            collection.Books = tmp; 
            return collection;
        }
        // Удаление книги
        public ListBook RemoveBook (ListBook collection, int index)
        {
            Book[] tmp = new Book[collection.Length() - 1];
            for (int i = 0; i < collection.Length(); ++i)
            {
                if (i < index)
                    tmp[i] = collection[i];
                if (i == index)
                    continue;
                if (i > index)
                    tmp[i - 1] = collection[i];
            }
            collection.Books = tmp;
            return collection;
        }
        public int Search(string str)  // Поиск книги по названию
        {
            for (int i = 0; i < Books.Length; ++i)
                if (Books[i].Name == str)
                    return i + 1;
            return -1;
        }
    }
}
