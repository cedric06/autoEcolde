using entrainement.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrainement.Repository
{
    using Domaine;
    public class AdresseRepository : CrudSQLRepository<Adresse>
    {
        private bddautoecoleContext context;
        public AdresseRepository(bddautoecoleContext context): base(context)
        {
            
        }


    }
}
