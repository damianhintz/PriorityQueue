using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C5;
using Shouldly;

namespace PriorityQueueTest
{
    [TestClass]
    public class PriorityQueueTest
    {
        [TestMethod]
        public void IntervalHeap_ShouldBe()
        {
            var heap = new IntervalHeap<int>();

            heap.AllowsDuplicates.ShouldBe(true);
            heap.Count.ShouldBe(0);
            heap.Add(1);
            heap.Count.ShouldBe(1);
            heap.FindMax().ShouldBe(1);
            heap.Add(1);
            heap.Count.ShouldBe(2);
            heap.Add(10);
            heap.FindMax().ShouldBe(10);
            heap.FindMin().ShouldBe(1);
            heap.Count.ShouldBe(3);
            heap.Add(5);
            heap.Count.ShouldBe(4);
            heap.FindMax().ShouldBe(10);
            heap.Add(100);
            heap.FindMax().ShouldBe(100);
            
        }
        
        [TestMethod]
        public void PriorityQueue_ShouldBe()
        {
            var heap = new PriorityQueue<int>();
            
            heap.Count.ShouldBe(0);

            heap.Enqueue(5);
            heap.Count.ShouldBe(1);
            heap.Max().ShouldBe(5);

            heap.Enqueue(10);
            heap.Count.ShouldBe(2);
            heap.Max().ShouldBe(10);

            heap.Enqueue(5);
            heap.Count.ShouldBe(3);
            heap.Max().ShouldBe(10);

            heap.Dequeue().ShouldBe(10);
            heap.Count.ShouldBe(2);
            heap.Max().ShouldBe(5);

            heap.Enqueue(3);
            heap.Max().ShouldBe(5);

            heap.Dequeue().ShouldBe(5);
            heap.Dequeue().ShouldBe(5);
            heap.Dequeue().ShouldBe(3);
            heap.Count.ShouldBe(0);

            for(int i = 0; i < 100; i++)
            {
                heap.Enqueue(i);
            }

            for (int i = 99; i >= 0; i--)
            {
                heap.Dequeue().ShouldBe(i);
            }

            
        }
    }
}
