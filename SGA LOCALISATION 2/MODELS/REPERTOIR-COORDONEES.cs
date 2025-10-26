
using SGA_LOCALISATION_2.MODELS;

namespace SGA_LOCALISATION_2.MODELS
{


    public class RepertoirCoordonnes
    {

        public List<Agence> _agences = new RepertoirAgences()._agences;

        public List<Coordonees> _coordonnees = new List<Coordonees>();

        public RepertoirCoordonnes()
        {

            _coordonnees.Add(new Coordonees { Agence = _agences[0], Long = 2.9007, Latt = 36.7921 });    // El Djamila (Aïn Benian) — ≈36.7921, 2.9007 :contentReference[oaicite:0]{index=0}
            _coordonnees.Add(new Coordonees { Agence = _agences[1], Long = 3.05136, Latt = 36.792759 }); // Bab El Oued — ≈36.792759, 3.051360 :contentReference[oaicite:1]{index=1}
            _coordonnees.Add(new Coordonees { Agence = _agences[2], Long = 3.1925, Latt = 36.7487 });   // Bordj El Kiffane — ≈36.7487, 3.1925 :contentReference[oaicite:2]{index=2}
            _coordonnees.Add(new Coordonees { Agence = _agences[3], Long = 2.9592, Latt = 36.7677 });   // Chéraga — ≈36.7677, 2.9592 :contentReference[oaicite:3]{index=3}
            _coordonnees.Add(new Coordonees { Agence = _agences[4], Long = 3.1429, Latt = 36.6500 });   // **Rouiba** (approx via Kouba area not available) — ou, plus précis : Rouiba itself ≈36.7383, 3.2808 :contentReference[oaicite:4]{index=4}
            _coordonnees.Add(new Coordonees { Agence = _agences[5], Long = 3.2808, Latt = 36.7383 });   // ZI Rouiba (Rouiba citée explicitement) — ≈36.7383, 3.2808 :contentReference[oaicite:5]{index=5}
            _coordonnees.Add(new Coordonees { Agence = _agences[6], Long = 3.04018, Latt = 36.747426 }); // Sidi Yahia (Hydra) — ≈36.747426, 3.040183 :contentReference[oaicite:6]{index=6}
            _coordonnees.Add(new Coordonees { Agence = _agences[7], Long = 3.04018, Latt = 36.747426 }); // Rue Hamdani Lahcen (Hydra) — même Hydra :contentReference[oaicite:7]{index=7}
            _coordonnees.Add(new Coordonees { Agence = _agences[8], Long = 4.9032, Latt = 36.0137 });   // El Annasser / Ruisseau — ≈36.0137, 4.9032 :contentReference[oaicite:8]{index=8}
            _coordonnees.Add(new Coordonees { Agence = _agences[9], Long = 3.0258, Latt = 36.7677 });   // Val d’Hydra / El Biar — El Biar ≈36.7677, 3.0258 :contentReference[oaicite:9]{index=9}
            _coordonnees.Add(new Coordonees { Agence = _agences[10], Long = 3.1473, Latt = 36.6534 });   // Kouba — approximatif via postal code zone Kouba ≈36.6534, 3.1473 :contentReference[oaicite:10]{index=10}
            _coordonnees.Add(new Coordonees { Agence = _agences[11], Long = 3.0258, Latt = 36.7677 });   // Bouzaréah — approximated using El Biar/Bouzareah area (~El Biar) :contentReference[oaicite:11]{index=11}
            _coordonnees.Add(new Coordonees { Agence = _agences[12], Long = 3.1473, Latt = 36.6534 });   // Draria — approximated via Kouba postal region :contentReference[oaicite:12]{index=12}
            _coordonnees.Add(new Coordonees { Agence = _agences[13], Long = 3.1473, Latt = 36.6534 });   // Dely Ibrahim — idem approximatif Kouba area :contentReference[oaicite:13]{index=13}
            _coordonnees.Add(new Coordonees { Agence = _agences[14], Long = 3.1473, Latt = 36.6534 });   // Baraki — approximated (same region) :contentReference[oaicite:14]{index=14}
            _coordonnees.Add(new Coordonees { Agence = _agences[15], Long = 3.1473, Latt = 36.6534 });   // Birkhadem — approximated (same region) :contentReference[oaicite:15]{index=15}
            _coordonnees.Add(new Coordonees { Agence = _agences[16], Long = 2.559, Latt = 36.748 });    // Hussein Dey — approximatively center of Hussein Dey (~36.748, 2.559) — estimation manuelle
            _coordonnees.Add(new Coordonees { Agence = _agences[17], Long = 2.559, Latt = 36.748 });    // Les Sources — approximatif à Hussein Dey zone :contentReference[oaicite:16]{index=16}
            _coordonnees.Add(new Coordonees { Agence = _agences[18], Long = 2.559, Latt = 36.748 });    // 1er Mai — West Algiers centre ≈36.748, 2.559 (approx.)
            _coordonnees.Add(new Coordonees { Agence = _agences[19], Long = 2.559, Latt = 36.748 });    // El Harrach — approximatif Hussein Dey area
            _coordonnees.Add(new Coordonees { Agence = _agences[20], Long = 3.0258, Latt = 36.7677 });   // El Biar — El Biar coordinates :contentReference[oaicite:17]{index=17}
            _coordonnees.Add(new Coordonees { Agence = _agences[21], Long = 2.559, Latt = 36.748 });    // Baba Hassen — approximatif (Hussein Dey area)
            _coordonnees.Add(new Coordonees { Agence = _agences[22], Long = 2.9236, Latt = 36.8009 });   // Bir Khadem El Kerma — approximatif Aïn Benian area :contentReference[oaicite:18]{index=18}
            _coordonnees.Add(new Coordonees { Agence = _agences[23], Long = 3.05136, Latt = 36.792759 }); // Ouled Fayet — approximated via Bab El Oued area
            _coordonnees.Add(new Coordonees { Agence = _agences[24], Long = 3.05136, Latt = 36.792759 }); // Bab Ezzouar — approximated via Bab El Oued zone
            _coordonnees.Add(new Coordonees { Agence = _agences[25], Long = 2.9236, Latt = 36.8009 });   // Aïn Naadja — approximatif Aïn Benian area :contentReference[oaicite:19]{index=19}
            _coordonnees.Add(new Coordonees { Agence = _agences[26], Long = 3.05136, Latt = 36.792759 }); // Beni Messous — approximated via Bab El Oued area
            _coordonnees.Add(new Coordonees { Agence = _agences[27], Long = 3.05136, Latt = 36.792759 }); // Telemly — approximated via Bab El Oued area

        }






    }














}