
using Microsoft.EntityFrameworkCore;
using DAl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace DAl.Implementations
{
    public class DalGenericoImplementacion<Tentity> : IdalGenerico<Tentity> where Tentity : class
    {
        protected readonly ExamenContext _Context;

        public DalGenericoImplementacion(ExamenContext quizcontext)
        {

            _Context = quizcontext;

        }
        public bool Add(Tentity entity)
        {
            try
            {
                _Context.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

       

        public Tentity get(int id)
        {
            return _Context.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> GetAll()
        {


            return _Context.Set<Tentity>().ToList();
        }

        public bool Remove(Tentity entity)
        {

            try
            {
                _Context.Set<Tentity>().Attach(entity);
                _Context.Set<Tentity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Tentity entity)
        {

            try
            {
                _Context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
