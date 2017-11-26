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
            object result;
            using (var connection = new SqlConnection())
            {
                using(var cmd = new SqlCommand("SELECT 1"))
                {
                    result = cmd.ExecuteNonQuery();
                }
            }

            Assert.NotNull(result);
        }
    }
}
