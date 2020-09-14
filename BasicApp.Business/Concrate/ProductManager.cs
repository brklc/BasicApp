using BasicApp.Business.Abstract;
using BasicApp.DataAccess.Abstract;
using BasicApp.DataAccess.Concrete.EfCore;
using BasicApp.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp.Business.Concrate
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
