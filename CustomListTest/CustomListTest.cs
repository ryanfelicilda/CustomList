using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_NewItemToEmptyList_ItemAddedToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // Act
            testList.Add(4);
            actual = testList[0];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_NewItemToEmptyList_ItemCountIncreaseOneIncrement()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // Act
            testList.Add(4);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_FourItemToList_ItemAddedToEndOfList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList[3];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_SevenItemToList_ItemAddedToEndOfList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 7;
            int actual;

            // Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            actual = testList[6];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_NewItemToExistingList_ItemCountIncreaseOneIncrement()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expected = 5;
            int actual;

            // Act
            testList.Add(5);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ItemFromExistingList_LastItemTakesPlaceOfRemovedItem()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(3);
            actual = testList[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
