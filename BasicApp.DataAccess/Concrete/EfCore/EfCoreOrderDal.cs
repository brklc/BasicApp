using BasicApp.DataAccess.Abstract;
using BasicApp.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp.DataAccess.Concrete.EfCore
{
    public class EfCoreOrderDal:EfCoreGenericRepository<Order,BasicContext>,IOrderDal
    {

    }
}
