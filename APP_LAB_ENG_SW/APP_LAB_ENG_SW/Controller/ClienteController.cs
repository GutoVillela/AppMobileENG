using System;
using System.Collections.Generic;
using System.Text;
using APP_LAB_ENG_SW.Database;
using APP_LAB_ENG_SW.Models;
using SQLiteNetExtensions.Extensions;

namespace APP_LAB_ENG_SW.Controller
{
    class ClienteController
    {
        private Conexao _conexao;

        public ClienteController()
        {
            _conexao = new Conexao();
            _conexao.ObterConexao().CreateTable<Cliente>();
        }

        public void Cadastrar(Cliente cliente)
        {
            _conexao.ObterConexao().Insert(cliente);
            _conexao.ObterConexao().Insert(cliente.LoginUsuario);
            _conexao.ObterConexao().UpdateWithChildren(cliente);

            //_conexao.ObterConexao().InsertWithChildren(cliente.Endereco, recursive: true);

            //_conexao.ObterConexao().InsertAllWithChildren(cliente.Endereco.Clientes);


        }

        public List<Cliente> Consultar()
        {
            return _conexao.ObterConexao().GetAllWithChildren<Cliente>();
            //return _conexao.ObterConexao().Table<Cliente>().ToList();//Retorna uma lista de usuários do banco de dados
        }


    }
}
