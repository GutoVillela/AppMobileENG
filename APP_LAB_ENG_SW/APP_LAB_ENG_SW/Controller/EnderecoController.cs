using System;
using System.Collections.Generic;
using System.Text;
using APP_LAB_ENG_SW.Database;
using APP_LAB_ENG_SW.Models;
using SQLiteNetExtensions.Extensions;

namespace APP_LAB_ENG_SW.Controller
{
    class EnderecoController
    {
        private Conexao _conexao;

        public EnderecoController()
        {
            _conexao = new Conexao();
            _conexao.ObterConexao().CreateTable<Endereco>();
        }

        public void Cadastrar(Endereco endereco)
        {
            _conexao.ObterConexao().InsertWithChildren(endereco);
        }

        public List<Endereco> Consultar()
        {
            return _conexao.ObterConexao().Table<Endereco>().ToList();//Retorna uma lista de usuários do banco de dados
        }
    }
}
