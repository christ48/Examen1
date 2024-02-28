using Fronend.Models;

namespace Fronend.Helpers.Interfaces
{
    public interface IDistritoHelper
    {
        List<DistritoViewModel> GetDistritos();

        DistritoViewModel GetDistrito(int id);

        DistritoViewModel AddDistrito(DistritoViewModel distrito);

        DistritoViewModel DeleteDistrito(int id);

        DistritoViewModel UpdateDistrito(DistritoViewModel distrito);
    }
}
