using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Book : IBorrowableBook
    {
        public int LibraryId { get ; set; }

        public string Title { get  ; set; }

        public int Pages { get; set; }

        public string Author { get; set; }

        public void CheckIn()
        {
            Console.WriteLine("Book CheckIn Date");
        }

        public void CheckOut()
        {
            Console.WriteLine("Book CheckOut Date");
        }

        public DateTime GetDueDate()
        {
            return DateTime.Now.AddDays(14);
        }
    }
}
