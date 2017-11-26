using System;
using System.Data.SqlClient;
using Xunit;

namespace xunit_issue
{
    public class Sqltest
    {
        [Fact]
        public void should_connect()
        {
            var ex = Assert.Throws<InvalidOperationException>(() =>
             {
                 using (var connection = new SqlConnection())
                 {
                     using (var cmd = new SqlCommand("SELECT 1"))
                     {
                         cmd.ExecuteNonQuery();
                     }
                 }
             });

             Assert.True(ex.Message.StartsWith("ExecuteNonQuery: Connection property"));
        }
    }
}
