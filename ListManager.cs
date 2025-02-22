using System;
using System.Collections.Generic;
using NUnit.Framework;

public class ListManager {
    public void AddElement(List<int> list, int element) {
        if (list == null) throw new ArgumentNullException(nameof(list));
        list.Add(element);
    }

    public bool RemoveElement(List<int> list, int element) {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Remove(element);
    }

    public int GetSize(List<int> list) {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Count;
    }
}

[TestFixture]
public class ListManagerTests {
    private ListManager listManager;
    private List<int> testList;

    [SetUp]
    public void Setup() {
        listManager = new ListManager();
        testList = new List<int>();
    }

    [Test]
    public void AddElement_ValidElement_IncreasesListSize() {
        listManager.AddElement(testList, 10);
        Assert.AreEqual(1, listManager.GetSize(testList));
    }

    [Test]
    public void AddElement_MultipleElements_IncreasesListSizeCorrectly() {
        listManager.AddElement(testList, 5);
        listManager.AddElement(testList, 15);
        Assert.AreEqual(2, listManager.GetSize(testList));
    }

    [Test]
    public void RemoveElement_ExistingElement_DecreasesListSize() {
        testList.Add(20);
        bool removed = listManager.RemoveElement(testList, 20);
        Assert.IsTrue(removed);
        Assert.AreEqual(0, listManager.GetSize(testList));
    }

    [Test]
    public void RemoveElement_NonExistingElement_ReturnsFalse() {
        testList.Add(30);
        bool removed = listManager.RemoveElement(testList, 40);
        Assert.IsFalse(removed);
        Assert.AreEqual(1, listManager.GetSize(testList));
    }

    [Test]
    public void GetSize_EmptyList_ReturnsZero() {
        Assert.AreEqual(0, listManager.GetSize(testList));
    }

    [Test]
    public void GetSize_NonEmptyList_ReturnsCorrectSize() {
        testList.Add(1);
        testList.Add(2);
        testList.Add(3);
        Assert.AreEqual(3, listManager.GetSize(testList));
    }

    [Test]
    public void AddElement_NullList_ThrowsException() {
        Assert.Throws<ArgumentNullException>(() => listManager.AddElement(null, 10));
    }

    [Test]
    public void RemoveElement_NullList_ThrowsException() {
        Assert.Throws<ArgumentNullException>(() => listManager.RemoveElement(null, 10));
    }

    [Test]
    public void GetSize_NullList_ThrowsException() {
        Assert.Throws<ArgumentNullException>(() => listManager.GetSize(null));
    }
}
