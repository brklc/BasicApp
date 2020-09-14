using BasicApp.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        void DeleteFromCart(string userId, int productId);
        void AddToCart(string userId, int productId, int quantity);
    }
}
