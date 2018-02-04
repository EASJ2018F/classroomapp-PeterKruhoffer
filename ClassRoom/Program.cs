using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasserum klasserum = new Klasserum();

            klasserum.KlasseNavn = "3F";
            klasserum.SemesterStart = new DateTime(2018,1,29);
            klasserum.Klasseliste = new List<Studerende>();
            
            Studerende s1 = new Studerende("Peter",10,30);
            Studerende s2 = new Studerende("David",05,10);
            Studerende s3 = new Studerende("Lasse",02,18);

            klasserum.Klasseliste.Add(s1);
            klasserum.Klasseliste.Add(s2);
            klasserum.Klasseliste.Add(s3);
            

            foreach (var element in klasserum.Klasseliste)
            {
                Console.WriteLine(element);
            }
        }
    }
}
