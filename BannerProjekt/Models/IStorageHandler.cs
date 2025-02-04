﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetProjekt.Models
{
    public interface IStorageHandler
    {
        //Ha a metódusok előtt nem adok meg láthatóságot, akkor is public-nak veszi.
        //Az interfészben a metódusok mindig public láthatóságúak és nem is lehetnek private-ok!
        //Az implementációban viszont már meg kell jelenjen a public! Nem lehet ettől szűkebb a láthatóságuk.

        const char CSV_SEPARATOR = ';';
        /// <summary>
        /// Betölti CSV fájlból a táblázat tartalmát
        /// </summary>
        /// <param name="fileName">A táblázat elérési útvonala és neve</param>
        void SaveToCsv(string fileName);

        /// <summary>
        /// Elmenti CSV fájlba a táblázat tartalmát
        /// </summary>
        /// <param name="fileName">A táblázat elérési útvonala és neve</param>
        /// <exception cref="FormatException ">Hibás formátumú táblázat esetén. Például létezik olyan sor, amiben a többitől eltérő számú cella szerepel</exception>
        /// <exception cref="FileNotFoundException ">Ha a fájl nem található!</exception>/// 
        void LoadFromCsv(string fileName);

        /// <summary>
        /// Összehasonlítja két táblázat szerkezetét. Egyezés esetén egyenlő a sorok száma és azon túl megegyeznek az oszlopok számában is
        /// </summary>
        /// <param name="file1">Első fájl útvonala és neve</param>
        /// <param name="file2">Második fájl útvonala és neve</param>
        /// <returns>true - ha a két táblázat szerkezete megegyezik.</returns>
        /// <exception cref="FileNotFoundException ">Ha a fájl nem található!</exception>///
        bool CompareStructure(string file1, string file2);

        /// <summary>
        /// Összehasonlítja két táblázat tartalmát. Csak azonos szerkezetű táblázatok hasonlíthatóak össze.
        /// </summary>
        /// <param name="file1">Első fájl útvonala és neve</param>
        /// <param name="file2">Második fájl útvonala és neve</param>
        /// <returns>true - ha a két táblázat tartalma celláról-cellára megegyezik.</returns>
        /// <exception cref="InvalidOperationException ">Ha két olyan táblázatot próbál összehasonlítani, amelyek szerkezete eltér egymástól</exception>
        /// <exception cref="FileNotFoundException ">Ha a fájl nem található!</exception>///
        bool CompareContent(string file1, string file2);
    }
}
