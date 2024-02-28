using Dal.Interface;
using DAl.Implementations;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Implementations
{
    public class DistrictoDALImpl:DalGenericoImplementacion<Distrito>,IDistritoDal
    {
        ExamenContext _context;
        public DistrictoDALImpl(ExamenContext context) : base(context)
        { 
            _context= context;
        }
    }
}
