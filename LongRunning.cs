using System;
using System.Threading;
using NUnit.Framework;

public class PerformanceTester {
    public void LongRunningTask() {
        Thread.Sleep(3000); // Simulating a long-running operation
    }
}

[TestFixture]
public class PerformanceTesterTests {
    private PerformanceTester tester;

    [SetUp]
    public void Setup() {
        tester = new PerformanceTester();
    }

    [Test, Timeout(2000)] // Test should fail if it takes longer than 2 seconds
    public void LongRunningTask_ShouldFailDueToTimeout() {
        tester.LongRunningTask();
    }
}
