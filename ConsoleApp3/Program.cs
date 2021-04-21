
using Google.Protobuf.WellKnownTypes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v2;
using WooCommerceNET.WooCommerce.v2.Extension;

namespace ConsoleApp3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RestAPI rest = new RestAPI("http://poyanmehrzarin.ir/wp-json/wc/v2/", "ck_74edea2fb8b68f0e7af22b25ab5a96184c4aaa2b", "cs_44426e8d1a5c07ff813eabf9706360af2ad25107");
            WCObject wc = new WCObject(rest);

            //Get all products

            /*var products = await wc.Product.GetAll();
            foreach(var item in products)
            {
                Console.WriteLine(item.id);
            }*/

            //Add new product
            /*Product p = new Product()
            {
                name = "test product 8",
                title = "test product 8",
                description = "test product 8",
                price = 8.0M
            };
            await wc.Product.Add(p);*/

            //Update products with new values
            var products1 = await wc.Product.Get(2144);
            var x = await wc.Product.Update(2144, new Product { regular_price = 0 ,sale_price=0 }); ;
            Console.WriteLine();
            var products = await wc.Product.Get(2144);
            Console.WriteLine(products.price);
            Console.ReadLine();

            //Update products with Null values
            /*await wc.Product.UpdateWithNull(128, new { name = "test 9", weight = "", date_on_sale_from = "", date_on_sale_to = "" });

            //Delete product
            await wc.Product.Delete(128);

            //Use parameters
            var p = await wc.Product.GetAll(new Dictionary<string, string>() {
                { "include", "10, 11, 12, 13, 14, 15" },
                { "per_page", "15" } });


            //Batch add/update/delete
            CustomerBatch cb = new CustomerBatch();

            List<Customer> create = new List<Customer>();
            create.Add(new Customer()
            {
                first_name = "first",
                last_name = "last",
                email = "first@lastsss.com",
                username = "firsthand",
                password = "12345"
            });

            List<Customer> update = new List<Customer>();
            update.Add(new Customer()
            {
                id = 4,
                last_name = "xu2"
            });

            List<int> delete = new List<int>() { 8 };
            cb.create = create;
            cb.update = update;
            cb.delete = delete;

            var c = await wc.Customer.UpdateRange(cb);*/

        }
    }
}

