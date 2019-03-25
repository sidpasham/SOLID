using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableBook book = new Book();
            book.CheckIn();
            Console.WriteLine($"This is the Due Date for Book =>{book.GetDueDate()}");
            book.CheckOut();

            IBorrowableDVD dvd = new DVD();
            dvd.CheckIn();
            Console.WriteLine($"This is the Due Date for DVD =>{dvd.GetDueDate()}");
            dvd.CheckOut();
        }
    }
}
