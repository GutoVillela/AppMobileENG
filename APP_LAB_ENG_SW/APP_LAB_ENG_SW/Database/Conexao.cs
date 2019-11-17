using System;
using System.Collections.Generic;
//using System.Data.SQLite;
using System.Text;
using Xamarin.Forms;
using APP_LAB_ENG_SW.Models;
using SQLite;

namespace APP_LAB_ENG_SW.Database
{
    class Conexao
    {
        private SQLiteConnection _conexao;

        public Conexao()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
        }

        public SQLiteConnection ObterConexao()
        {
            return _conexao;
        }


    }
}
