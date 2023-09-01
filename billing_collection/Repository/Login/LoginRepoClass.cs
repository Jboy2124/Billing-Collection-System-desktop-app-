using billing_collection.Config;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billing_collection.Repository.Login
{
    public class LoginRepoClass : LoginRepoInterface
    {
        public async Task<bool> Authentication(string username, string password)
        {
			try
			{
				using (IDbConnection conn = Connection.MySQLConnect()) {
					string authQuery =
						"SELECT * " +
						"FROM tbl_login " +
						"WHERE username = @user " +
						"AND password = @pass";

					var result = await conn.QueryFirstOrDefaultAsync<int>(authQuery, new
					{
						user = username,
						pass = password,
					}) ;

					if (result > 0)
					{
						return true;
					}
					else {
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
        }
    }
}
