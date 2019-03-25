using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class DVD : IBorrowableDVD
    {
        public int Size { get ; set ; }
        public int LibraryId { get; set ; }
        public string Title { get ; set ; }

        public void CheckIn()
        {
            Console.WriteLine("DVD CheckIn Date");
        }

        public void CheckOut()
        {
            Console.WriteLine("DVD CheckOut Date");
        }

        public DateTime GetDueDate()
        {
            return DateTime.Now.AddDays(30);
        }
    }
}
