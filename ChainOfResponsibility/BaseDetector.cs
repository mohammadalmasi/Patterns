namespace ChainOfResponsibility
{
    public abstract class BaseDetector
    {
        BaseDetector _nextDetector;
        internal abstract bool Handel();

        public bool Check()
        {
            if (Handel())
                return true;

            else if (_nextDetector != null)
                return _nextDetector.Check();

            return false;
        }

        internal void NextDetector(BaseDetector nextDetector)
        {
            _nextDetector = nextDetector;
        }
    }
}