using entrainement.Domaine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrainement.Repository
{
    public class CrudSQLRepository<T> : CrudRepository<T> where T : class
    {
        private bddautoecoleContext context = null;
        private DbSet<T> table = null;
        public CrudSQLRepository(bddautoecoleContext context)
        {
            this.context = context;
            this.table = context.Set<T>();
        }
        public IQueryable<T> Filter(T model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adresse> FindAll()
        {
            // SELECT * FROM chercheur;
            return this.context.Adresse;
        }

        public IQueryable<T> FindAll()
        {
            return this.table;
        }

        public T FindByID(int id)
        {
            return this.table.Where(model => model.Id == id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T model)
        {
            throw new NotImplementedException();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }
    }
