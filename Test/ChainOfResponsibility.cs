using ChainOfResponsibility;
using Xunit;

namespace Test
{
    public class ChainOfResponsibility
    {
        [Fact]
        public void Check()
        {
            BaseDetector detector = BaseDetectorFactory.GetAll();
            bool result = detector.Check();
            Assert.True(result);
            Assert.False(!result);
        }
    }
}
