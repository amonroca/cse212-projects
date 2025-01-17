using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue with the following people and priorities: Bob (2), Tim (5), Sue (3).
    // Expected Result: Tim must be removed and Bob and Sue must remain in the queue.
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_1()
    {
        var expectedResult = "Tim";
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        var priority = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, priority);
    }

    [TestMethod]
    // Scenario: Create a priority queue with the same priority for all people: Bob (2), Tim (2), Sue (2).
    // Expected Result: Bob must be removed and Tim and Sue must remain in the queue.
    // Defect(s) Found: AreEqual failed. Expected Bob but was Tim.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var expectedResult = "Bob";
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 2);
        var priority = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, priority);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Check if the queue is empty.
    // Expected Result: An InvalidOperationException is thrown.
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}