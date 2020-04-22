using System;
using System.Collections.Generic;
using System.Text;

namespace EvidentaPersoane
{
    public class Copil : IPersoana
    {
        public string Nume { get ; set; }
        public string Prenume { get; set; }
        public int Varsta { get ; set ; }
        public string NumeComplet { get {
                return Nume + Prenume;
            }}
        public string Ocupatie
        {
            get;
            set;
        }
        public Copil(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Ocupatie = "gradinita";
        }
        public bool Buletin()
        {
            return false;
        }
        public void Afisare()
        {
            Console.WriteLine(NumeComplet); ;
        }
    }
}
