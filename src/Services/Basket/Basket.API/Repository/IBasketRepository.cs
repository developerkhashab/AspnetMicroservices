using Basket.API.Entities;

namespace Basket.API.Repository
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart userName);
        Task DeleteBasket(string userName);
    }
}
