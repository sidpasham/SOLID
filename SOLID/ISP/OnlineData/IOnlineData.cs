using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IOnlineData: ILibraryItem
    {
        string URL { get; set; }
    }
}
