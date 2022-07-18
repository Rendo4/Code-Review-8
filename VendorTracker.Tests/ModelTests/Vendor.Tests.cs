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
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
  }
}