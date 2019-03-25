using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class OnlineData : IOnlineData
    {
        public string URL { get ; set ; }
        public int LibraryId { get ; set; }
        public string Title { get ; set ; }
    }
}
