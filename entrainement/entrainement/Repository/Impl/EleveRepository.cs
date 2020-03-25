using entrainement.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrainement.Repository.Impl
{
    public class EleveRepository
    {
        private bddautoecoleContext context;
        public EleveRepository(bddautoecoleContext context)
        {
            this.context = context;
        }

        public IQueryable<Eleves> FindAll()
        {
            return this.context.Eleves.Select(Eleves => eleve);
        }

        public IQueryable<Eleves> Filter(EleveRepository model)
        {
            throw new NotImplementedException();
        }

        public Eleves FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Eleves> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Adresse Save(Eleves model)
        {
            throw new NotImplementedException();
        }

        public Adresse Update(Eleves model)
        {
            throw new NotImplementedException();
        }
    }
}
