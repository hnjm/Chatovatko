﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Premy.Chatovatko.Libs.Logging
{
    public interface ILoggerOutput
    {
        void Log(ILoggerMessage message);
        String GetName();
    }
}
