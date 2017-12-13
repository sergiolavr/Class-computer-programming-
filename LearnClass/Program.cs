using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Война и мир", "Л. Н. Толстой", 1869);
            b1.GetInformation();
            
            Book b2 = new Book();
            b2.GetInformation();
            
            Console.ReadLine();
        }
    }
    
}
