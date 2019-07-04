using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shoes.Services.CartApi.Domain
{
    public interface ICartRepository
    {
        Task<Cart> GetCartAsync(string cartId);
         IEnumerable<string>  GetUsers();
        Task<Cart> UpdateCartAsync(Cart basket);
        Task<bool> DeleteCartAsync(string id);
    }
}
