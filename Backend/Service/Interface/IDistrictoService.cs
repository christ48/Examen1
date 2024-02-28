using Backend.Models;

namespace Backend.Service.Interface
{
    public interface IDistrictoService
    {
        IEnumerable<DistrictoModel> GetDistrictos();

        DistrictoModel GetbyId(int id);

        bool addDistricto(DistrictoModel districto);

        bool updateDistricto(DistrictoModel districto);

        bool deleteDistricto(DistrictoModel districto);


    }
}
