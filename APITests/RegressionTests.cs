using System;
using APITestingWRestSharp;
using NUnit.Framework;

namespace APITests;

[TestFixture]
public class RegressionTests
{
    [Test]
    public void VerifyListOfUsers()
    {
        var demo = new Demo();
        var response = demo.GetUsers();

        Assert.AreEqual(2, response.Page);
        Assert.AreEqual("Michael", response.Data[0].first_name);
    }
}

