using StockApp.Busines.Interface;
using StockApp.WindowsForms._Inicializar;
using StockApp.WindowsForms.Cadastros;

namespace StockApp.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                var banco = new InicializarDataBase();
                banco.Init();
            }
            catch (Exception)
            {

                throw;
            }

            Application.Run(new frmCategoria());
        }
    }
}