using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroEvento_Core.Data.EF.Repositorios;
using CadastroEvento_Core.Entidades;

namespace Cadastro_Evento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            List<Motoclube> mcs = new MCRepositorio().GetAllEntities().ToList();

            if (mcs == null || mcs.Count == 0)
                Application.Run(new FormInitial());
            else
                Application.Run(new GerarEvento(mcs[0]));
        }
    }
}
