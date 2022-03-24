using System.Threading.Tasks;
using WebApplication4.DAL.Abstract;
using WebApplication4.Entities;
using WebApplication4.Entities.RequestModels;
using WebApplication4.Entities.ResponseModels;

namespace WebApplication4.Business
{
    public class OrderService
    {
        private readonly IRepositoryOrder _order;
        public OrderService(IRepositoryOrder order)
        {
            _order = order;
        }

        public async Task<TCreateOrder> CreateOrder(RCreateOrder Order)
        {
            return await _order.Create(Order);
        }
    }
}
