using System.Data;
using System.Data.SqlClient;

namespace AddressBook.Data
{
    public class DapperContext : IDapperContext
    {
        public IConfiguration Configuration { get; set; }
        public string ConnectionString { get; set; }
        public DapperContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
            this.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}