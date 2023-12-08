using StockApp.Busines.Interface;
using StockApp.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.WindowsForms._Inicializar
{
    internal class InicializarDataBase
    {
        private  readonly IDataBaseService _databaseService;

        public InicializarDataBase ()
        {
            _databaseService = new DataBaseService();
        }
        internal void Init()
        {
            _databaseService.CriarBanco();
            _databaseService.CriarTabelaCategoria();
        }
    }
}
