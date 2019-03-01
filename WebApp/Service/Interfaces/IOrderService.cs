using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Service
{
    public interface IOrderService : IBaseService<Order, OrderDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailDto> orderDetails);
    }
}
