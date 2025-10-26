using Microsoft.AspNetCore.Mvc;
using SGA_LOCALISATION_2.MODELS;
using SecuDeApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics.Eventing.Reader;


namespace SGA_LOCALISATION_2.Controllers
{







    [ApiController]
    [Route("[controller]")]

    public class AgenceslistsController : ControllerBase
    {

        private readonly RepertoirAgences _repertoire;

        public AgenceslistsController()
        {
            _repertoire = new RepertoirAgences();
        }
        // apporter les changements necessaires pour les parametres

        [Authorize]
        [HttpGet("GetClosestAgence")]

        public IActionResult GetAgence([FromQuery] double Latt, [FromQuery] double Long)
        {
            var agence = _repertoire.GetAgences();



            if (agence == null)
            {
                Console.WriteLine(" i was here");
                return NotFound("Aucune agence trouvée ");

            }
            var agenceProche = TrouverPlusProche(Latt, Long, agence);
            if (agenceProche == null)
            {
                Console.WriteLine(" i was here 2");
                return NotFound("Impossible de déterminer l'agence la plus proche");
            }
            else
            {
                double distanceKm = HaversineKm(Latt, Long, agenceProche.Position.Latt, agenceProche.Position.Long);

                return Ok(new
                {




                    Ville = agenceProche.Adresse.Ville,
                    Commune = agenceProche.Adresse.Commune,
                    Cite = agenceProche.Adresse.Cite,
                    agenceProche.CodeAgence,
                    agenceProche.Num,
                    Latitude = agenceProche.Position.Latt,
                    Longitude = agenceProche.Position.Long,
                    DistanceKm = Math.Round(distanceKm, 2)

                });
            }


        }

                public static Agence TrouverPlusProche(double userLat, double userLon, List<Agence> candidats)
        {
            Agence best = null;
            double bestDist = double.MaxValue;

            foreach (var a in candidats)
            {
                double dist = HaversineKm(userLat, userLon, a.Position.Latt, a.Position.Long);
                if (dist < bestDist)
                {
                    bestDist = dist;
                    best = a;
                }
            }

            return best;
        }

        // Formule Haversine pour calculer la distance en km
        static double HaversineKm(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371.0; // Rayon Terre en km
            double dLat = ToRad(lat2 - lat1);
            double dLon = ToRad(lon2 - lon1);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRad(lat1)) * Math.Cos(ToRad(lat2)) *
                        Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        static double ToRad(double deg) => deg * Math.PI / 180.0;

    }
}
