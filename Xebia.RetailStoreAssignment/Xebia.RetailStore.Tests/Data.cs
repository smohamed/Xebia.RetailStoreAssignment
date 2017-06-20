using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore.Tests
{
    static class Data
    {
        public static List<Product> Products
        {
            get;
            private set;
        }

        public static List<User> Users
        {
            get;
            private set;
        }

        static Data()
        {
            Products = GetProductsCatalog();
            Users = Getusers();
        }

        private static List<Product> GetProductsCatalog()
        {
            var productsCat = new List<Product>
            {
                new Product
                {
                    Name = "P1",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P2",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P3",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P4",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P5",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P6",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P7",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P8",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P9",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P10",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P11",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P12",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P13",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P14",
                    ProductType = ProductType.Grocery,
                    Price = 100
                },
                new Product
                {
                    Name = "P15",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P16",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P17",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P18",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P19",
                    ProductType = ProductType.Other,
                    Price = 100
                },
                new Product
                {
                    Name = "P20",
                    ProductType = ProductType.Other,
                    Price = 100
                }
            };

            return productsCat;
        }

        private static List<User> Getusers()
        {
            var users = new List<User>
            {
                new User
                {
                    Name = "U1",
                    IsEmployee = true,
                    IsAffiliate = true,
                    JoiningDate = DateTime.UtcNow.AddMonths(-12)
                },
                new User
                {
                    Name = "U2",
                    IsEmployee = false,
                    IsAffiliate = true,
                    JoiningDate = DateTime.UtcNow.AddMonths(-18)
                },
                new User
                {
                    Name = "U3",
                    IsEmployee = false,
                    IsAffiliate = false,
                    JoiningDate = DateTime.UtcNow.AddMonths(-12)
                },
                new User
                {
                    Name = "U4",
                    IsEmployee = false,
                    IsAffiliate = false,
                    JoiningDate = DateTime.UtcNow.AddMonths(-24)
                },
                new User
                {
                    Name = "U5",
                    IsEmployee = false,
                    IsAffiliate = false,
                    JoiningDate = DateTime.UtcNow.AddMonths(-24).AddDays(-1)
                },
                new User
                {
                    Name = "U6",
                    IsEmployee = false,
                    IsAffiliate = false,
                    JoiningDate = DateTime.UtcNow.AddMonths(-24).AddDays(1)
                },
                new User
                {
                    Name = "U7",
                    IsEmployee = false,
                    IsAffiliate = false,
                    JoiningDate = DateTime.UtcNow.AddYears(-3)
                }
            };

            return users;
        }
    }
}
