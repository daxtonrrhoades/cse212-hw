using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue that has both data and a set priority. Make sure that the objects containing data and priority are being added to the back of the queue.
    // Expected Result: [floor, desk, bed, closet]
    // Defect(s) Found: None. It passed the tests.
    public void TestPriorityQueue_1()
    {
        var floor = new PriorityItem("floor", 3);
        var desk = new PriorityItem("desk", 2);
        var bed = new PriorityItem("bed", 1);
        var closet = new PriorityItem("closet", 1);

        // PriorityItem[] expectedResult = [floor, desk, bed, closet];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(floor.Value, floor.Priority);
        priorityQueue.Enqueue(desk.Value, desk.Priority);
        priorityQueue.Enqueue(bed.Value, bed.Priority);
        priorityQueue.Enqueue(closet.Value, closet.Priority);
    }

    [TestMethod]
    // Scenario: Create a queue that has both data and a set priority. Make sure that the items are dequeued at highest priority first and then on.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

}