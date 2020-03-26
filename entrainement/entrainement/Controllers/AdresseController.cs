using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entrainement.Domaine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entrainement.Controllers
{
    [ApiController]
    [Route("/chercheurs")]
    public class AdresseController
    {
        public AdresseController()
        {
        }

        public ICollection<Adresse> findAll()
        {
            ICollection<Adresse> chercheurs = new List<Adresse>();
            Adresse c1 = new Adresse()
            {
                Adresse1 = "333 Rue des enfer"
            };
            Adresse c2 = new Adresse()
            {
                Adresse1 = "666 Rue de la paix"
            };
            chercheurs.Add(c1);
            chercheurs.Add(c2);

            return chercheurs;
        }
    }
}