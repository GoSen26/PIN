﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Util
/// </summary>
public static class Util
{
    public static string Kriptiraj(string txt)
    {
        //Ugrađena .NET biblioteka za kriptiranje
        SHA256Managed sha = new SHA256Managed();
        //Pretvorimo text u niz bajtova da bi kriptirali
        byte[] poljeBajtova = Encoding.UTF8.GetBytes(txt);
        //Sada ide algoritam
        byte[] poljeRezultata = sha.ComputeHash(poljeBajtova);
        // Vrati rezultat algoritma kao string
        return Convert.ToBase64String(poljeRezultata);
    }
}