
namespace SGA_LOCALISATION_2.MODELS
{
     

    public class RepertoirAgences
    { 
      
       
             public List<Adress> _adresses = RepertoirAdress._adresses;
             public List<Agence> _agences = new List<Agence>();
            
        
        public RepertoirAgences()        
        { 
      // REGLER LE PROBLEME D ADRESS 
              
            _agences.Add(new Agence { Adresse = _adresses[0], CodeAgence = "27", Num = "021600682" });
            _agences.Add(new Agence { Adresse = _adresses[1], CodeAgence = "15", Num = "021620154" });
            _agences.Add(new Agence { Adresse = _adresses[2], CodeAgence = "19", Num = "21203115" });
            _agences.Add(new Agence { Adresse = _adresses[3], CodeAgence = "33", Num = "21361618" });
            _agences.Add(new Agence { Adresse = _adresses[4], CodeAgence = "35", Num = "21816356" });
            _agences.Add(new Agence { Adresse = _adresses[5], CodeAgence = "4", Num = "21816356" });
            _agences.Add(new Agence { Adresse = _adresses[6], CodeAgence = "36", Num = "021600682" });
            _agences.Add(new Agence { Adresse = _adresses[7], CodeAgence = "00001", Num = "021600682" });
            _agences.Add(new Agence { Adresse = _adresses[8], CodeAgence = "37", Num = "0676963" });
            _agences.Add(new Agence { Adresse = _adresses[9], CodeAgence = "8", Num = "21922140" });
            _agences.Add(new Agence { Adresse = _adresses[10], CodeAgence = "6", Num = "021470668" });
            _agences.Add(new Agence { Adresse = _adresses[11], CodeAgence = "7", Num = "021793930" });
            _agences.Add(new Agence { Adresse = _adresses[12], CodeAgence = "9", Num = "021353280" });
            _agences.Add(new Agence { Adresse = _adresses[13], CodeAgence = "10", Num = "21336530" });
            _agences.Add(new Agence { Adresse = _adresses[14], CodeAgence = "11", Num = "21405772" });
            _agences.Add(new Agence { Adresse = _adresses[15], CodeAgence = "12", Num = "21405772" });
            _agences.Add(new Agence { Adresse = _adresses[16], CodeAgence = "13", Num = "21565761" });
            _agences.Add(new Agence { Adresse = _adresses[17], CodeAgence = "14", Num = "non disponible" });
            _agences.Add(new Agence { Adresse = _adresses[18], CodeAgence = "16", Num = "21448699" });
            _agences.Add(new Agence { Adresse = _adresses[19], CodeAgence = "17", Num = "021663920" });
            _agences.Add(new Agence { Adresse = _adresses[20], CodeAgence = "18", Num = "21514550" });
            _agences.Add(new Agence { Adresse = _adresses[21], CodeAgence = "20", Num = "21922140" });
            _agences.Add(new Agence { Adresse = _adresses[22], CodeAgence = "21", Num = "21352075" });
            _agences.Add(new Agence { Adresse = _adresses[23], CodeAgence = "22", Num = "21451482" });
            _agences.Add(new Agence { Adresse = _adresses[24], CodeAgence = "23", Num = "non disponible" });
            _agences.Add(new Agence { Adresse = _adresses[25], CodeAgence = "25", Num = "23839525" });
            _agences.Add(new Agence { Adresse = _adresses[26], CodeAgence = "29", Num = "21297292" });
            _agences.Add(new Agence { Adresse = _adresses[27], CodeAgence = "30", Num = "21933840" });
            _agences.Add(new Agence { Adresse = _adresses[28], CodeAgence = "32", Num = "21745428" });




                         

        }
        public List<Agence> GetAgences()
        {
            return _agences;
        }

    }

}