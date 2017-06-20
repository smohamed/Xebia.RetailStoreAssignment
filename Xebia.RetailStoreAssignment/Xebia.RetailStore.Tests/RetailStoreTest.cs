using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xebia.RetailStore.Tests
{
    public class RetailStoreTest
    {
        [Fact]
        public void UserIsEmployeeWithMixOfProducts()
        {
            var bill = new Bill
            {
                User = Data.Users[0],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[1],
                       Data.Products[2],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 390);
        }

        [Fact]
        public void UserIsEmployeeWithGroceriesOnly()
        {
            var bill = new Bill
            {
                User = Data.Users[0],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[1],
                       Data.Products[2]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 190);
        }

        [Fact]
        public void UserIsEmployeeWithNoGroceries()
        {
            var bill = new Bill
            {
                User = Data.Users[0],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 200);
        }

        [Fact]
        public void UserIsAffiliateWithMixOfProducts()
        {
            var bill = new Bill
            {
                User = Data.Users[1],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[1],
                       Data.Products[2],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 450);
        }

        [Fact]
        public void UserIsAffiliateWithGroceriesOnly()
        {
            var bill = new Bill
            {
                User = Data.Users[1],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[1],
                       Data.Products[2]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 190);
        }

        [Fact]
        public void UserIsAffiliateWithNoGroceries()
        {
            var bill = new Bill
            {
                User = Data.Users[1],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 260);
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithMixOfProducts()
        {
            var bill = new Bill
            {
                User = Data.Users[2],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[1],
                       Data.Products[2],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 475);
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithGroceriesOnly()
        {
            var bill = new Bill
            {
                User = Data.Users[2],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[1],
                       Data.Products[2]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 190);
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithNoGroceries()
        {
            var bill = new Bill
            {
                User = Data.Users[2],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 285);
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithMixOfProducts()
        {
            var bill = new Bill
            {
                User = Data.Users[5],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[1],
                       Data.Products[2],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 475);
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithGroceriesOnly()
        {
            var bill = new Bill
            {
                User = Data.Users[5],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[1],
                       Data.Products[2]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 190);
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithNoGroceries()
        {
            var bill = new Bill
            {
                User = Data.Users[5],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 285);
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithMixOfProducts()
        {
            var bill = new Bill
            {
                User = Data.Users[6],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[1],
                       Data.Products[2],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 465);
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithGroceriesOnly()
        {
            var bill = new Bill
            {
                User = Data.Users[6],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[1],
                       Data.Products[2]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 190);
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithNoGroceries()
        {
            var bill = new Bill
            {
                User = Data.Users[6],
                OrderDetails = new Order
                {
                    OrderItems = new List<Product>
                    {
                       Data.Products[0],
                       Data.Products[3],
                       Data.Products[4]
                    }
                }
            };

            Assert.Equal(new BillCalculator().CalculateNetPayable(bill), 275);
        }
    }
}
