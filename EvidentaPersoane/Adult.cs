using System;
using System.Collections.Generic;
using System.Text;

namespace EvidentaPersoane
{
    public class Adult : IPersoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public string NumeComplet
        {
            get
            {
                return Nume + Prenume;
            }
        }
        public string Ocupatie
        {
            get; set;
        }
        public Adult(string nume, string prenume, int varsta,bool casatorie)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Ocupatie = "serviciu";
            Casatorie = casatorie;
        }
        public bool Casatorie
        {
            get;set;
        }
        public bool Buletin()
        {
                return true;
        }
        public void Afisare()
        {
            Console.WriteLine(NumeComplet); ;
        }
    }
}
