using Laba5Podderzh;
using NUnit.Framework;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Do_InputGreaterThan100Point7_Returns1006()  //границы тест 100.6 -до
        {
            // Arrange
            float input = 100.6f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(100, result);
        }
        [Test]
        public void Do_InputGreaterThan100Point7_Returns1007() //границы тест 100.7-вкл
        {
            // Arrange
            float input = 100.7f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(1000, result);
        }
        [Test]
        public void Do_InputGreaterThan100Point7_Returns1008() //границы тест 100.8-после
        {
            // Arrange
            float input = 100.8f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void Do_InputInRangeFrom0To100Point7_ReturnsIntegerPart() //границы от 0 +
        {
            // Arrange
            float input = 0.1f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Do_InputEquals0_ThrowsArgumentException() //0
        {
            // Arrange
            float input = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Converter.Do(input));
        }
        [Test]
        public void Do_InputInRangeFrom0To100Point7_ReturnsIntegerPart1() //границы до 0 -
        {
            // Arrange
            float input = -0.9f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-5, result);
        }
      
  
        [Test]
        public void Do_InputInRangeFromMinus30Point4To0_ReturnsIntegerPartMinus512()
        {
            // Arrange
            float input = -30.3f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-35, result);
        }
        [Test]
        public void Do_InputInRangeFromMinus30Point4To0_ReturnsIntegerPartMinus5()
        {
            // Arrange
            float input = -30.4f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-35, result);
        }
        [Test]
        public void Do_InputInRangeFromMinus30Point4To0_ReturnsIntegerPartMinus51()
        {
            // Arrange
            float input = -30.5f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-2000, result);
        }
        [Test]
        public void Do_InputInRangeFromMinusInfinityToMinus30Point5_ReturnsMinus2000() //+0.1 -0.1
        {
            // Arrange
            float input = -30.6f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-2000, result);
        }
        [Test]
        public void Do_InputInRangeFromMinusInfinityToMinus30Point5_ReturnsMinus20001() //+0.1 -0.1
        {
            // Arrange
            float input = float.MinValue;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-2000, result);
        }
        [Test]
        public void Do_InputInRangeFromMinusInfinityToMinus30Point5_ReturnsMinus20002() //+0.1 -0.1
        {
            // Arrange
            float input = float.MinValue + 0.1f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(-2000, result);
        }
        [Test]
        public void Do_InputInRangeFromMinusInfinityToMinus30Point5_ReturnsMinus20003() //+0.1 -0.1
        {
            // Arrange
            float input = float.MaxValue;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(1000, result);
        }
  
        [Test]
        public void Do_InputInRangeFromMinusInfinityToMinus30Point5_ReturnsMinus20005() //+0.1 -0.1
        {
            // Arrange
            float input = float.MaxValue - 0.1f;

            // Act
            int result = Converter.Do(input);

            // Assert
            Assert.AreEqual(1000, result);
        }
        [Test]
        public void Do_InputOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Converter.Do(float.NaN));
        }
    }
}