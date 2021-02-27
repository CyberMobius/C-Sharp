﻿using System;
using System.Collections.Generic;

using DataStructures.Heap;

using NUnit.Framework;

namespace DataStructures.Tests.Heap
{
    static class FibonacciHeapTests
    {
        private static FibonacciHeap<int> BuildTestHeap()
        {
            var heap = new FibonacciHeap<int>();
            var elems = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in elems)
            {
                heap.Push(i);
            }

            return heap;
        }

        [Test]
        public static void Push_AddElements_BuildCorrectHeap()
        {
            var heap = BuildTestHeap();

            Assert.AreEqual(1, heap.Peek());
            Assert.AreEqual(10, heap.Count);
        }

        public static void Pop_RemoveElements_HeapStillValid()
        {
            var heap = BuildTestHeap();

            Assert.AreEqual(1, heap.Peek());
            Assert.AreEqual(10, heap.Count);

            Assert.AreEqual(1, heap.Pop());
            Assert.AreEqual(9, heap.Count);

            Assert.AreEqual(2, heap.Pop());
            Assert.AreEqual(8, heap.Count);
        }

        [Test]
        public static void Pop_EmptyHeap_ThrowsCorrectException()
        {
            var heap = new FibonacciHeap<int>();

            Assert.Throws<InvalidOperationException>(() => heap.Pop());
        }

        [Test]
        public static void Peek_NonEmptyHeap_ReturnsCorrectAnswer()
        {
            var heap = BuildTestHeap();

            Assert.AreEqual(1, heap.Peek());
        }

        [Test]
        public static void Peek_EmptyHeap_ThrowsCorrectException()
        {
            var heap = new FibonacciHeap<int>();

            Assert.Throws<InvalidOperationException>(() => heap.Peek());
        }

        // [Test]
        // public static void Remove_EmptyHeap_ThrowsCorrectException()
        // {
        //     var heap = new BinaryHeap<int>();

        //     Assert.Throws<ArgumentException>(() => heap.Remove(1));
        // }
    }
}