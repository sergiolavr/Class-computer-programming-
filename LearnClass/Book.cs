using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    class Book
    {
        public string name;
        public string author;
        public int year;

        public Book()
        {
            name = "хуяк-хуяк и в продакшн";
            author = "хуяк-хуяк и в продакшн";
            year = 1;
            /*
             типо грибы, потому что в комментариях можно писать все, что угодно))
             и еще немножко
             и еще чуть-чуть
            */
        }
        
        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Книга '{name}' (автор {author}) была издана в {year} году");
        }
    }
}
