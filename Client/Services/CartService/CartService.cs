using Blazored.LocalStorage;
using Blazored.Toast.Services;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly HttpClient _http;


        public List<Product> products { get; set; } = new List<Product>();
        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
        }
        /*public async Task AddToCart(Product product)
        {
            var cart = await _localStorage.GetItemAsync<List<Product>>("cart");
            if (cart == null)
            {
                cart = new List<Product>();
            }


            cart.Add(product);

            await _localStorage.SetItemAsync("cart", cart);


            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }*/

        public async Task AddToCart(CartItem item, Product product)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            var sameItem = cart.Find(x => x.ProductId == item.ProductId);
            
            if (sameItem == null)
            {
                cart.Add(item);
              
            }
            else
            {


                sameItem.Quantity += item.Quantity;
              
              
            }

            //cart.Add(product);

            await _localStorage.SetItemAsync("cart", cart);


            _toastService.ShowSuccess(product.Title, "Added to cart:");

            OnChange.Invoke();
        }


        public async Task<List<CartItem>> GetCartItems()
        {
          
        var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if (cart==null)
            {
                return result;
            }
           /* foreach (var item in cart)
            {
                //var product = await _http.GetFromJsonAsync<Product>($"https://localhost:44310/api/Products/{item.Id}");
                var cartItem = new CartItem
                {
                    ProductId = item.Id,
                    Title = item.Title,
                    Image = item.Image,
                    Price = item.Price,
                    
                };
                result.Add(cartItem);
            }*/
            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return ;
            }
            var cartItem = cart.Find(x => x.ProductId == item.ProductId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();

        }
    }
}
