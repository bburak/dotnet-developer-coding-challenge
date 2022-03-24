using System.Threading.Tasks;
using WebApplication4.Entities.RequestModels;
using WebApplication4.Entities.ResponseModels;

namespace WebApplication4.DAL.Abstract
{
    public interface IRepositoryOrder
    {
        public Task<TCreateOrder> Create(RCreateOrder _object);
    }
}
