namespace Builder
{
    internal class Query
    {
        public string OperationName { get; set; }

        public IList<string> ReturnFields { get; set; }

        public IDictionary<string, object> Conditions { get; set; }
    }
}