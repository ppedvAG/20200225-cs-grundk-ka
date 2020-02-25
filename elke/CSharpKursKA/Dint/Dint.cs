﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dint
{
    class Dint
    {
        static void Main(string[] args)
        {
            #region M2

            // ===========================================================
            Console.WriteLine("\n ### int literale ###");
            int iInt1 = 4;
            int iInt2 = -3;

            Console.WriteLine("# int possible values #");

            // ===========================================================
            Console.WriteLine("\n ### int.MinValues ###");
            Console.WriteLine($"intMinValue: {int.MinValue}");

            Console.WriteLine("\n ### int.MaxValues ###");
            Console.WriteLine($"intMaxValue: {int.MaxValue}");

            Console.WriteLine("\n ### int.Parse() ###");
            Console.Write("Geben Sie eine Zahl ein: ");// Cursor bleibt an der zeile stehen
            string sZahlalsString = Console.ReadLine();
            int iGetcastedString = int.Parse(sZahlalsString);
            Console.WriteLine($"iGetcastedString as int: {iGetcastedString is int}"); //true
            Console.WriteLine($"iGetcastedString Gettype: {iGetcastedString.GetType()}"); //true


            // ===========================================================
            Console.WriteLine("\n ### (int)kommazahl ###");
            double dKommazahl = 2.5;
            int iGanzzahl = (int)dKommazahl;
            Console.WriteLine($"Ganzzahl: { iGanzzahl}");







            #endregion

            // #############################################################################
            // #############################################################################
            // #############################################################################

            #region MORE FANCY STUFF

            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            #endregion

            Console.ReadKey();
        }
    }
}
