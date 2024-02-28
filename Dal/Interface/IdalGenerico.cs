using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAl.Interface
{
    public interface IdalGenerico<Tentity> where Tentity : class
    {
        Tentity get(int id);
        IEnumerable<Tentity > GetAll();

        IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate);
        
    bool Add(Tentity entity);


        bool Update(Tentity entity);
        bool Remove(Tentity entity);

    }
}
