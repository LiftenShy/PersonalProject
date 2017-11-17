using System.Threading.Tasks;

namespace SocialMusic.Authorize.Service.Interfaces
{
    public interface IConnector<T>
        where T : class
    {
        Task<bool> PostAsJson(T model);
    }
}
