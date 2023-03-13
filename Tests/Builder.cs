using Builder;

namespace Tests
{
    [TestClass]
    public class Builder
    {
        [TestMethod]
        public void Check()
        {
            var queryBuilder = new QueryBuilder();
            queryBuilder.AddOperationName("accounts");
            queryBuilder.AddReturnField("id");
            queryBuilder.AddReturnField("name");
            queryBuilder.AddReturnField("street");
            queryBuilder.AddReturnField("postalcode");
            queryBuilder.AddReturnField("city");
            string query = queryBuilder.Build();

            Assert.IsNotNull(query);
        }
    }
}
