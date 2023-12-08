using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.SqlConexao

{
    internal static class SqlServerContext
    {
        internal static string ConexaoSemBanco => @"server=.\SQLEXPRESS; Integrated Security=True; User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockApp;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";

    }
}
