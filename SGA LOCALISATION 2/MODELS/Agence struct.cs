namespace SGA_LOCALISATION_2.MODELS
{
    public class Agence

    {
       // public string Nom { get; set; }//blk remplacer nom avec statut genre agence ou direction
        public string CodeAgence { get; set; }
        public Adress Adresse { get; set; }
        public Coordonees Position { get; set; }
        public string Num { get; set; } 
        public bool Distributeurs { get; set; }
    }
}
