using MyNamespace;
namespace Testing_Pruebas
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SquareCalculated()
        {
            // Arrange //
            int choice = 2;
            double large = 6, width = 10, expected = 60, total;

            // Act //
            total = MyClass.AreaCalculator(large, width);

            // Assert //
            Assert.AreEqual(expected, total);
        }
        [TestMethod]
        public void PenthagonCalculated()
        {
            // Arrange //
            int choice = 4;
            double side = 70, expected = 525, total;
            float apothem = 3;

            // Act //
            total = MyClass.AreaCalculator(side, apothem);

            // Assert //
            Assert.AreEqual(expected, total);
        }

        [TestMethod]
        public void CircleCalculated()
        {
            // Arrange //
            int choice = 3;
            double radius = 45, pi = Math.PI, elevated = 2,expected = 6361.73, total;

            // Act //
            total = MyClass.AreaCalculator(radius, pi, elevated);

            // Assert //
            Assert.AreEqual(expected, total);
        }
    }
}