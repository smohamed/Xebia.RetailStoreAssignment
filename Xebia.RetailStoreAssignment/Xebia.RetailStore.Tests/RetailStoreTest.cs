using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore;
using Xunit;

namespace Xebia.RetailStore.Tests
{
    public class RetailStoreTest
    {
        [Fact]
        public void UserIsEmployeeWithMixOfProducts()
        {
            var customer = Data.Users[0];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(390, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsEmployeeWithGroceriesOnly()
        {
            var customer = Data.Users[0];
            var order = new Order(customer);

            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(190, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsEmployeeWithNoGroceries()
        {
            var customer = Data.Users[0];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(200, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithMixOfProducts()
        {
            var customer = Data.Users[1];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(450, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithGroceriesOnly()
        {
            var customer = Data.Users[1];
            var order = new Order(customer);

            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            
            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(190, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsAffiliateWithNoGroceries()
        {
            var customer = Data.Users[1];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(260, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithMixOfProducts()
        {
            var customer = Data.Users[2];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(475, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithGroceriesOnly()
        {
            var customer = Data.Users[2];
            var order = new Order(customer);

            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(190, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForLessThanTwoYearsWithNoGroceries()
        {
            var customer = Data.Users[2];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(285, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithMixOfProducts()
        {
            var customer = Data.Users[5];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(475, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithGroceriesOnly()
        {
            var customer = Data.Users[5];
            var order = new Order(customer);

            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(190, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForJustTwoYearsWithNoGroceries()
        {
            var customer = Data.Users[5];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(285, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithMixOfProducts()
        {
            var customer = Data.Users[6];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(465, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithGroceriesOnly()
        {
            var customer = Data.Users[6];
            var order = new Order(customer);

            order.AddItem(Data.Products[1]);
            order.AddItem(Data.Products[2]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(190, calc.CalculateNetPayableAmount(bill));
        }

        [Fact]
        public void UserIsCustomerForMoreThanTwoYearsWithNoGroceries()
        {
            var customer = Data.Users[6];
            var order = new Order(customer);

            order.AddItem(Data.Products[0]);
            order.AddItem(Data.Products[3]);
            order.AddItem(Data.Products[4]);

            var bill = new Bill(order);

            var calc = BillCalculatorFactory.Instance.Create(PercentageDiscount.Instance, FixedDiscount.Instance);
            Assert.Equal(275, calc.CalculateNetPayableAmount(bill));
        }
    }
}
