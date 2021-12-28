using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace WebApI.Models
{
    public class Repository : IRepository
    {
        private readonly IDbConnection dbConnection;

       public Repository (IDbConnection dbcon)
        {
            dbConnection = dbcon;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return dbConnection.Query<Category>("SELECT * FROM Categories;");     
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return dbConnection.Query<Order>("SELECT * FROM Orders;");
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbConnection.Query<Product>("SELECT * FROM Products;");
        }

        public IEnumerable<User> GetAllUsers()
        {
            return dbConnection.Query<User>("SELECT * FROM Users;");
        }
    }
}
