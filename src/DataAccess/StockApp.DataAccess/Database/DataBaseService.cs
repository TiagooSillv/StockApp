using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.DataAccess.SqlConexao;
using Dapper;
using StockApp.Busines.Interface;

namespace StockApp.DataAccess.Database
{
    public partial class DataBaseService : IDataBaseService
    {

        public void CriarBanco()
        {
            var sql = @"
                        IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'StockApp')
                        BEGIN
                          CREATE DATABASE StockApp
                         END
                        ";
            using (var connection = new SqlConnection(SqlServerContext.ConexaoSemBanco))
            {
                var resultado = connection.Execute(sql);

            };
        }

        
    }
}
