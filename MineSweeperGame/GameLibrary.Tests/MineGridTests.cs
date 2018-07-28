using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;

namespace GameLibrary.Tests
{
    [TestClass]
    public class MineGridTests
    {
        [TestMethod]
        public void MineGrid_ConstructorWorks()
        {
            MineGrid grid = new MineGrid(20, 14, 30);

            // Parameters of grid are correct.
            Assert.IsTrue(grid.Width == 20);
            Assert.IsTrue(grid.Height == 14);
            Assert.IsTrue(grid.NumberOfMines == 30);

            // Throws exception if too many mines
            Assert.ThrowsException<InvalidOperationException>(() => new MineGrid(20, 14, 113));
        }
    }
}
