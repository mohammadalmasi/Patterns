﻿namespace Builder
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly Query _query;

        public QueryBuilder()
        {
            _query = new Query
            {
                ReturnFields = new List<string>(),
                Conditions = new Dictionary<string, object>(),
            };
        }

        public void AddOperationName(string operationName)
        {
            _query.OperationName = operationName;
        }

        public void AddReturnField(string fieldName)
        {
            _query.ReturnFields.Add(fieldName);
        }

        public void AddCondition(string key, object value)
        {
            _query.Conditions.Add(key, value);
        }

        public string Build()
        {
            var conditions = new List<string>();
            foreach (var kvp in _query.Conditions)
            {
                conditions.Add(string.Concat(kvp.Key + ": " + kvp.Value));
            }
            var condition = "";
            if (_query.Conditions.Count > 0)
            {
                condition = "(condition: { " + string.Join(", ", conditions) + " })";
            }

            return @"query{" + _query.OperationName + "" + condition + " {nodes{" + string.Join(", ", _query.ReturnFields) + " }}}";
        }
    }
}
