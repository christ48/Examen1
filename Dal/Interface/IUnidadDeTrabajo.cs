using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interface
{
    public interface IUnidadDeTrabajo : IDisposable
    {
       IDistritoDal _DistritoDal { get; }
        bool Complete();
    }
}
