using Entities.Models;
using Repository.Infrastructure;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public interface IProductService
    {
        Product Add(Product productCategory);
        void Update(Product productCategory);
        Product Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAll(string keyword);
        Product GetByID(int id);
        IEnumerable<Product> GetLastest(int top);
        IEnumerable<Product> GetHotProduct(int top);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _IUnitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork IUnitOfWork)
        {
            this._productRepository = productRepository;
            this._IUnitOfWork = IUnitOfWork;
        }
        public Product Add(Product productCategory)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAll(string keyword)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetHotProduct(int top)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetLastest(int top)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Product productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
