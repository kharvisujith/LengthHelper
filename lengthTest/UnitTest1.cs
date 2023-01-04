
namespace lengthTest
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("",0)]
        [InlineData("123",3)]
        [InlineData("123456789010",12)]
        public void Test1(string data,int expectedresult)
        {
            LengthHelper inst = new LengthHelper();
            int res = inst.findLength(data);
            Assert.Equal(expectedresult, res);
        }

        [Fact]
        public void testforNullReferenceException()
        {
            LengthHelper inst = new LengthHelper();
            Action res = ()=> inst.findLength(null);
            NullReferenceException ex = Assert.Throws<NullReferenceException>(res);
            Assert.Equal("data cannot be null", ex.Message);
        }
    }
}