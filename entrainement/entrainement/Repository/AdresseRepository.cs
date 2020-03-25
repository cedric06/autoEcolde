using entrainement.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrainement.Repository
{
    public class AdresseRepository : CrudRepository<Adresse>
    {
        private bddautoecoleContext context;
        public AdresseRepository(bddautoecoleContext context)
        {
            this.context = context;
        }

        public IQueryable<Adresse> FindAll()
        {
            //SELECT * FROM chercheur;
            return this.context.Adresse.Select(AdresseRepository => adresse);
        }

        public IQueryable<Adresse> Filter(AdresseRepository model)
        {
            throw new NotImplementedException();
        }

        public Adresse FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adresse> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Adresse Save(Adresse model)
        {
            throw new NotImplementedException();
        }

        public Adresse Update(Adresse model)
        {
            throw new NotImplementedException();
        }
    }
}
