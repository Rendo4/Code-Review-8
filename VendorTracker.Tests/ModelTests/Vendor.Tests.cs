using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }
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

  }
}