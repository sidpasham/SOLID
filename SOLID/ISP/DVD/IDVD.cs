﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IDVD: ILibraryItem
    {
        int Size { get; set; }
    }
}
