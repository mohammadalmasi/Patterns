using ChainOfResponsibility;

namespace Tests
{
    [TestClass]
    public class ChainOfResponsibility
    {
        [TestMethod]
        public void Check()
        {
            BaseDetector detector = BaseDetectorFactory.GetAll();
            bool result = detector.Check();
            Assert.IsTrue(result);
            Assert.IsFalse(!result);
        }
    }
}