using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesIstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test Vendor";
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "Test Description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Costco";
      string name02 = "Fred Meyer";
      Vendor newVendor1 = new Vendor(name01, "Test Description");
      Vendor newVendor2 = new Vendor(name02, "Test Description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Costco";
      string name02 = "Fred Meyer";
      Vendor newVendor1 = new Vendor(name01, "Test Description");
      Vendor newVendor2 = new Vendor(name02, "Test Description");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_associatesOrderwithVendor_OrderList()
    {
      Order newOrder = new Order("July Order","Regular monthly order", 30, "July 1st, 2022");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Costco";
      Vendor newVendor = new Vendor(name, "Test Description");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}