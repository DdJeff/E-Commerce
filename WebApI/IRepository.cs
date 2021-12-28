using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApI.Models;

namespace WebApI
{
  public interface IRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public IEnumerable<Order> GetAllOrders();
        public IEnumerable<Product> GetAllProducts();
        public IEnumerable<User> GetAllUsers();

    }
}
