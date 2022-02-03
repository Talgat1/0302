using _0302.Unit;
using _0302.House;
using _0302.InterfaceWeapon;
using _0302.InterfaceUnit;
using System;

namespace _0302
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitHouse ar = new UnitHouse();
            var Lena = ar.MakeArcher();
            
            WeaponHouse wh = new WeaponHouse();
            var bow1 = wh.MakeBow();

            Lena.Blow(bow1);
        }
    }
}
