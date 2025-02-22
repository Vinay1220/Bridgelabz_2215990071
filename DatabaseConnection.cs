using System;
using NUnit.Framework;

public class DatabaseConnection {
    public bool IsConnected { get; private set; }

    public void Connect() {
        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    public void Disconnect() {
        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}

[TestFixture]
public class DatabaseConnectionTests {
    private DatabaseConnection db;

    [SetUp]
    public void Setup() {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void Teardown() {
        db.Disconnect();
    }

    [Test]
    public void Connect_EstablishesConnection() {
        Assert.IsTrue(db.IsConnected);
    }

    [Test]
    public void Disconnect_ClosesConnection() {
        db.Disconnect();
        Assert.IsFalse(db.IsConnected);
    }

    [Test]
    public void Setup_EnsuresConnectionBeforeEachTest() {
        Assert.IsTrue(db.IsConnected, "Setup should ensure the connection is established before each test.");
    }
}
