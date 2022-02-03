using System;
using System.Collections.Generic;
using System.Text;
using _0302.InterfaceUnit;
using _0302.InterfaceWeapon;

namespace _0302.InterfaceShaman
{
    interface Improvement : Parametrs
    {
        //public int healf;

        //public int berserk => throw new NotImplementedException();

        //public int defense => throw new NotImplementedException();

        //public int speed => throw new NotImplementedException();

        public void Fury(Parametrs ff)
        {
            ff.Param();
        }
    }
}
