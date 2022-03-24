using AutoMapper;
using System.Threading.Tasks;
using WebApplication4.DAL.Abstract;
using WebApplication4.DAL.Context;
using WebApplication4.Entities;
using WebApplication4.Entities.RequestModels;
using WebApplication4.Entities.ResponseModels;
using WebApplication4.Enums;

namespace WebApplication4.DAL.Concrete
{
    public class RepositoryOrder : IRepositoryOrder
    {
        ApplicationDbContext _dbContext;
        IMapper _mapper;
        public RepositoryOrder(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        
        public async Task<TCreateOrder> Create(RCreateOrder _object)
        {
            var request =  _mapper.Map<Order>(_object);

            #region Shipping Process
            if (request.Category == "Giyim")
            {
                request.CargoName = "Aras Kargo";
            }
            if (request.Category == "Gida")
            {
                request.CargoName = "Yurtici Kargo";
            }
            request.CargoStatus = (short)CargoStatusEnum.Hazirlaniyor;
            #endregion Shipping Process

            var obj = await _dbContext.Orders.AddAsync(request);
            _dbContext.SaveChanges();

            var response = _mapper.Map<TCreateOrder>(obj.Entity);
            return response;
        }
    }
}
