﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_IW5_2018.Infrastructure.Interface
{
    interface IPhotoObject
    {
        string Name { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }
}
