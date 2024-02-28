using Dal.Interface;
using DAl.Interface;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl.Implementations
{
    public class UnidadDeTrabajo: IUnidadDeTrabajo
    {
        public IDistritoDal _DistritoDal { get; }

        private readonly ExamenContext _context;

        public UnidadDeTrabajo(IDistritoDal distritoDal, ExamenContext context)
        {
            _DistritoDal = distritoDal;
            _context = context;
     }
        public bool Complete()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
