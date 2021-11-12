
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem Item, Product Product);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);

        Task EmptyCart();

    }
}
