namespace Builder
{
    internal interface IQueryBuilder
    {
        void AddOperationName(string operationName);

        void AddReturnField(string fieldName);

        void AddCondition(string key, object value);

        string Build();
    }
}
