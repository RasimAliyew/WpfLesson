﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Container_MVVM.Messaging
{
    class NavigationMessage
    {
        public ViewModelBase Current { get; set; }
    }
}
