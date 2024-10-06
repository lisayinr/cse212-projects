using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item and dequeue it afterwards.
    // Expected Result: The item that is dequed should be "Low"
    // Defect(s) Found: None  
    public void TestPriorityQueue_1()
    {
        var priorityQueueEnqueue = new PriorityQueue();
        priorityQueueEnqueue.Enqueue("Low", 1);
        var result = priorityQueueEnqueue.Dequeue();
        Assert.AreEqual("Low", result, "Expected 'Low to be dequeued.");
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: An error exception will be thrown.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }

    [TestMethod]
    // Scenario: Enqueuing multiple items with different priorities and then dequeuing.
    // Expected Result: The first item to be dequeued will be the item with "High" priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Low", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result, "Expected 'High' to be dequeued first.");
    }

    [TestMethod]
    // Scenario: Enqueing items with same priority.
    // Expected Result: The first added item with the same priority should be dequed first.
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);

        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();

        Assert.AreEqual("First", result1, "Expect 'First' to be dequeued first.");
        Assert.AreEqual("Second", result2, "Expect 'Second' to be dequeued second.");

    }
}