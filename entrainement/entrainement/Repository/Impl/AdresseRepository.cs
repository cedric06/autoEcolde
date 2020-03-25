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
            return this.context.Adresse;
        }

        public IQueryable<Adresse> Filter(AdresseRepository model)
        {
            throw new NotImplementedException();
        }

        public Adresse FindByID(int id)
        {
            // SELECT * FROM chercheur WHERE Id==id LIMIT 1;
            return this.context.Adresse
                .Where(adresse => adresse.Id == id)
                .First();
        }

        public void Remove(int id)
        {
            // DELETE chercheur where ID = id;
            this.context.Remove(this.FindByID(id));
            this.context.SaveChanges();
        }

        public Adresse Save(Adresse model)
        {
            // INSERT INTO chercheur (nom, ...) VALUE (..., ..., ...)
            this.context.Add(model);
            this.context.SaveChanges();
        }

        public Adresse Update(Adresse model)
        {
            // UPDATE chercheur SET nom=model.nom, prenom=model.prenom WHERE ID = model.id;
            this.context.Update(model);
            this.context.SaveChanges();
        }
    }
}
