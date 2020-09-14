using BasicApp.DataAccess.Abstract;
using BasicApp.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicApp.DataAccess.Concrete.EfCore
{
    public class EfCoreCartDal : EfCoreGenericRepository<Cart, BasicContext>, ICartDal
    {
        public override void Update(Cart entity)
        {
            using (var context = new BasicContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }

        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context = new BasicContext())
            {
                var cmd = @"delete from CartItem where CartId=@p0 And ProductId=@p1";
                context.Database.ExecuteSqlCommand(cmd, cartId, productId);
            }
        }

        public Cart GetByUserId(string userId)
        {
            using (var context = new BasicContext())
            {
                return context.Carts
                    .Include(i => i.CartItems)
                    .ThenInclude(i => i.Product)
                    .FirstOrDefault(i => i.UserId == userId);
            }
        }
    }
}
