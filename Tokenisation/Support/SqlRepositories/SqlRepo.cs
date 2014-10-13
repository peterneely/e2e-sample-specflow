using System;
using System.Configuration;
using System.Data.Common;
using SqlFu;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.SqlRepositories
{
    public class SqlRepo
    {
        public SqlRepo()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ctWebDb"].ConnectionString;
            SqlFuDao.ConnectionStringIs(connectionString, DbEngine.SqlServer);
        }

        public T GetValue<T>(string query)
        {
            return Try(db => db.GetValue<T>(query), default(T));
        }

        public StoredProcedureResult ExecuteStoredProcedure(string name, object parameters)
        {
            return Try(db => db.ExecuteStoredProcedure(name, parameters), new StoredProcedureResult());
        }

        private static T Try<T>(Func<DbConnection, T> command, T error)
        {
            try
            {
                using (var db = SqlFuDao.GetConnection())
                {
                    return command(db); 
                }
            }
            catch (Exception ex)
            {
                return error;
            }
        }
    }
}
