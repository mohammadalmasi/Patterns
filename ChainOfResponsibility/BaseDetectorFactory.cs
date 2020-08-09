namespace ChainOfResponsibility
{
    public class BaseDetectorFactory
    {
        public static BaseDetector GetAll()
        {
            var a = new DetectorA();
            var b = new DetectorB();
            var c = new DetectorC();

            a.NextDetector(b);
            b.NextDetector(c);

            return a;
        }
    }
}
