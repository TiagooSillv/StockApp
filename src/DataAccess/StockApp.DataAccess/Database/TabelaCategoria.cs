using Dapper;
using Microsoft.Data.SqlClient;
using StockApp.DataAccess.SqlConexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.Database
{
    public partial class DataBaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                        CREATE TABLE Categorias(
                            Id int,
                            Nome varchar(100)
                        );
                        ";
            using (var connection = new SqlConnection(SqlServerContext.ConexaoComBanco))
            {
                var resultado = connection.Execute(sql);

            };
        }
    }
}
