using Shape_Library;

namespace TestShape
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircle()
        {
            Shape shape = new Circle(123);

            Assert.Equal(772.8317927830891, shape.square());
        }
        [Fact]
        public void TestSquare()
        {
            Shape shape = new Square(2,6,7);

            Assert.Equal(false, shape is not null && shape is Circle);
            Assert.Equal(5.562148865321747, shape.square());
        }
    }
}