using Online_bookstore.Basket;
using Online_bookstore.Products;

namespace Online_bookstore.Discount
{
    public interface IDiscount
    {
        int GetTotalDiscount(IBasket basket);
        int GetDiscount(IProduct product);
    }
}
