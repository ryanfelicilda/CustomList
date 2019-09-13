using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Method_Condition_ExpectedResult()
        {
            // Condition to test:


            // Arrange


            // Act


            // Assert


        }
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
        public void Add_NewItemToExistingList_ItemAddedToEndOfList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expected = 4;
            int actual;

            // Act
            testList.Add(4);
            actual = testList[3];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        public void Add_NewItemToExistingList_ItemCountIncreaseOneIncrement()
        {
            // Arrange


            // Act


            // Assert


        }
    }
}
