using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found:    
    public void TestPriorityQueue_1()
    {
        var priorityQueueEnqueue = new PriorityQueue();
        priorityQueueEnqueue.Enqueue("Low", 1);
        var result = priorityQueueEnqueue.Dequeue();
        Assert.AreEqual("Low", result, "Expected 'Low to be dequeued.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}