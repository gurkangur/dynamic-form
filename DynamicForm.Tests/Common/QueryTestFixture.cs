using DynamicForm.Data;
using System;
using Xunit;

namespace DynamicForm.Tests.Common
{
    public class QueryTestFixture : IDisposable
    {
        public ApplicationDbContext Context { get; private set; }

        public QueryTestFixture()
        {
            Context = ApplicationDbContextFactory.Create();

        }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}
