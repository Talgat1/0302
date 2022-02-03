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
            UnitHouse archer1 = new UnitHouse();
            var Lena = archer1.MakeArcher();
            Lena.Par();

            UnitHouse shaman1 = new UnitHouse();
            var Boris = shaman1.MakeShaman();
            Boris.Par();
            Boris.Fury(Lena);

            PostHouse ph1 = new PostHouse();

            //WeaponHouse wh = new WeaponHouse();
            //var bow1 = wh.MakeBow();

            //Lena.Blow(bow1);
        }
    }
}
