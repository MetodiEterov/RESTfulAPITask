using System.Collections.Generic;
using System.Threading.Tasks;

using Entity.Layer.Models;

namespace Entity.Layer.Contracts
{
    /// <summary>
    /// IOrderRepository interface
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// GetAllOrders contract
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Root>> GetAllOrders();
    }
}
