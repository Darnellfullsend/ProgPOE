using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;

namespace Tests
{
    //Unit test for the calories method
    [TestClass()]
    public class RecipeTests
    {
        [TestMethod()]
        public void totalCaloriesTest()
        {
            // Arrange
            double[] calories = { 100.5, 200.3, 150.8 };
            Recipe recipe = new Recipe();

            // Act
            double result = recipe.totalCalories(calories);

            // Assert
            Assert.AreEqual(451.6, result);
        }
    }
}