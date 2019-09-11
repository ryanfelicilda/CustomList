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
            // Condition to test:
            // Add an item to an empty list and new item will be in [0] index.

            // Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 5;
            int actual;

            // Act
            test.Add(5);
            actual = test[0];

            // Assert
            Assert.AreEqual(expected, actual);

        }
        public void Add_NewItemToEmptyList_ItemCountIncreaseOneIncrement()
        {
            // Condition to test:
            // Add an item to an empty list and item count increases one increment.

            // Arrange


            // Act


            // Assert


        }
        public void Add_NewItemToExistingList_ItemAddedToEndOfList()
        {
            // Condition to test:
            // Add an item to an existing list and new item is added at the end of the list.

            // Arrange


            // Act


            // Assert


        }
        public void Add_NewItemToExistingList_ItemCountIncreaseOneIncrement()
        {
            // Condition to test:
            // Add an item to an existing list and item count increases one increment.

            // Arrange


            // Act


            // Assert


        }
    }
}
