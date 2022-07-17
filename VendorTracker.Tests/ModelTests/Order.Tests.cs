using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests :IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesIstanceOfOrder_Order()
    {
      Order newOrder = new Order("July Order","Regular monthly order", 30, "July 1st, 2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void isOrderPropertyRead()
    {
      Order newOrder = new Order("July Order","Regular monthly order", 30, "July 1st, 2022");
      Assert.AreEqual(30, newOrder.Price);
    }
    /// Test Setter method goes here

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order newOrder1 = new Order("July Order","Regular monthly order", 30, "July 1st, 2022");
      Order newOrder2 = new Order("August Order", "Regular monthly order", 30, "August 1st, 2022");
      List<Order> newList = new List<Order> { newOrder1 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}