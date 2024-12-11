using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// using Sajátprojekt;
using ConsoleApp1;
using System.Collections.Generic;
using System.IO;

namespace UnitTestProject1.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Szemely_Konstruktor_Input_Teszt()
        {
            // Arrange - érték beállítás
            string adat1 = "1;Kovács Dominik;2000-04-15;Budapest";
            int id = 1;
            string nev = "Kovács Dominik";
            DateTime szulido = DateTime.Parse("2000-04-15");
            string varos = "Budapest";

            // Act - metódus hívás
            Szemely szemely = new Szemely(adat1);

            // Assert
            Assert.AreEqual(id, szemely.Id);
            Assert.AreEqual(nev, szemely.Nev);
            Assert.AreEqual(szulido, szemely.Szulido);
            Assert.AreEqual(varos, szemely.Varos);
        }

        [TestMethod]
        public void Fajl_Beolvasas_Lista_Feltoltessel()
        {
            // Act
            string fajlNev = @"C:\Users\János\Desktop\12_03_Struktúra_konstruktor_személyek_2\ConsoleApp1\ConsoleApp1\bin\Debug\szemelyek.txt";
            int adatokSzama = 10;
            List<Szemely> adatok = new List<Szemely>();

            // Arrange
            if (File.Exists(fajlNev))
            {
                Program.Beolvas(fajlNev, adatok);
            }
            else
            {
                Assert.Fail("A fájl nem található, vagy nem létezik!");
            }

            // Assert
            Assert.AreEqual(adatokSzama, adatok.Count);
        }
    }
}
