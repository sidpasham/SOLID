using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IBorrowable
    {
        DateTime GetDueDate();

        void CheckIn();

        void CheckOut();

    }
}
