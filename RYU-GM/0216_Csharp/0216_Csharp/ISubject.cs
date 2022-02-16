﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216_Csharp
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void unregisterObserver(IObserver o);

        void notifyObserver();
    }
}
