using entrainement.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrainement.Repository
{
    public class AdresseRepository : CrudSQLRepository<Adresse>
    {
     
        public AdresseRepository(bddautoecoleContext context): base(context)
        {

        }


    }
}
