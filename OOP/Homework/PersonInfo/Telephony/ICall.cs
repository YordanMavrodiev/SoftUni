﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICall
    {
        void Dial(string number);
    }
}
