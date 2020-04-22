namespace EvidentaPersoane
{

    public interface IPersoana
    {
        public void Afisare();
        public string Nume
        {
            get;
            set;
        }
        public string Prenume
        {
            get;
            set;
        }
        public int Varsta
        {
            set;
            get;
        }
        public string NumeComplet
        {
            get;
        }
        public string Ocupatie
        {
            get;
            set;
        }
        public bool Buletin();
        
    }

}

