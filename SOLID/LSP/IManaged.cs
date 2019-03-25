using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IManaged
    {
        void AssignManager(string managername);

        void GiveEmployeeReviews(Employee emp);
    }
}
