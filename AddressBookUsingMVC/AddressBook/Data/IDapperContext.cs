using System.Data;

namespace AddressBook.Data
{
    public interface IDapperContext
    {
        public IDbConnection CreateConnection();
    }
}