using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection =connection.GetCustomersCollection();
            var document = new BsonDocument
            {
                {"CustomerName",customer.CustomerName },
                {"CustomerSurname",customer.CustomerSurname },
                {"CustomerCity",customer.CustomerCity },
                {"CustomerBalance",customer.CustomeBalance },
                {"CustomerShoppingCount",customer.CustomeShopppingCount }


            };
            customerCollection.InsertOne(document);
        
        }

         public List<Customer> GetAllCustomer() 
        {
            var connection = new MongoDbConnection();   
            var customerCollection=connection.GetCustomersCollection();
            var customers=customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var c in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),
                    CustomeBalance = decimal.Parse(c["CustomerBalance"].ToString()),
                    CustomerCity = c["CustomerCity"].ToString(),
                    CustomerName = c["CustomerName"].ToString(),
                    CustomeShopppingCount = int.Parse(c["CustomerShoppingCount"].ToString()),
                    CustomerSurname = c["CustomerSurname"].ToString(),


                }) ;
            }
            return customerList;
        }

        public void DeleteCustomer(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter =Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }
        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updatedValue =Builders<BsonDocument>.Update  
            .Set("CustomerName", customer.CustomerName)
               .Set("CustomerSurame", customer.CustomerSurname)
               .Set("CustomerCity", customer.CustomerCity)
               .Set("CustomerBalance", customer.CustomeBalance)
               .Set("CustomerShoppingCount", customer.CustomeShopppingCount);
              customerCollection.UpdateOne(filter,updatedValue);
        }

        public Customer GetCustomerById(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = Customer.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomeBalance = decimal.Parse(result.CustomeBalance),
                CustomerId = result.CustomerId,
                CustomerName = result["CustomerName"].ToString(),

                CustomerCity = result["CustomerCity"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomeShopppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),


            };                                        

        }

    }
}
