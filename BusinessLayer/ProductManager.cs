using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repository<Product> productRepository = new Repository<Product>();

        public List<Product> GetAll()
        {
            return productRepository.List();
        }

        public List<Product> GetByName(string p)
        {
            return productRepository.List(x => x.ProductName == p);
        }

    }
}
