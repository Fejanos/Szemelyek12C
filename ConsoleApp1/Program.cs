using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public struct Szemely
    {
        public int Id;
        public string Nev;
        public DateTime Szulido;
        public string Varos;
        public Szemely(string sor)
        {
            string[] darabolt = sor.Split(';');
            Id = int.Parse(darabolt[0]);
            Nev = darabolt[1];
            Szulido = DateTime.Parse(darabolt[2]);
            Varos = darabolt[3];
        }
    }
    public class Program
    {
        static List<Szemely> adatok = new List<Szemely>();
        static void Main(string[] args)
        {

        }
        // Teszteléshez
        public static void Beolvas(string fajl, List<Szemely> adatok2)
        {
            foreach (string sor in File.ReadAllLines(fajl).Skip(1))
            {
                Szemely sz = new Szemely(sor);
                adatok2.Add(sz);
            }
        }
        public static void Beolvas(string fajl)
        {
            // Foreach megoldás
            //var beFajl = File.ReadAllLines(fajl).Skip(1);
            // .Skip(1) fejléc kihagyása
            foreach(string sor in File.ReadAllLines(fajl).Skip(1))
            {
                Szemely sz = new Szemely(sor);
                adatok.Add(sz);
            }

            // StreamReader megoldás
            /*
            StreamReader sr = new StreamReader(fajl);
            string fejlec = sr.ReadLine(); // Fejléc beolvasása
            while(!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Szemely sz = new Szemely(sor);
                adatok.Add(sz);
            }
            sr.Close();
            */

            // using kulcsszóval
            /*
            using(StreamReader sw = new StreamReader(fajl))
            {
                // ...
            }
            */
        }
    }
}
