using System;
using System.Collections.Generic;
using System.Text;
using APP_LAB_ENG_SW.Models;
using SQLite;
using APP_LAB_ENG_SW.Database;
using SQLiteNetExtensions.Extensions;

namespace APP_LAB_ENG_SW.Controller
{
    class UsuarioController
    {
        private Conexao _conexao;

        public UsuarioController()
        {
            _conexao = new Conexao();
            _conexao.ObterConexao().CreateTable<Usuario>();
        }


        public void Cadastrar(Usuario usuario)
        {
            _conexao.ObterConexao().InsertWithChildren(usuario);
        }

        public List<Usuario> Consultar()
        {
            return _conexao.ObterConexao().Table<Usuario>().ToList();//Retorna uma lista de usuários do banco de dados
        }

        public Usuario ConsultarUsuario(Usuario usuario)
        {
            return _conexao.ObterConexao().Table<Usuario>().Where(a => a.Login == usuario.Login).FirstOrDefault();//Retorna um usuário que tenha atenda as condições da cláusula Where
        }

        public void Atualizar(Usuario usuario)
        {
            _conexao.ObterConexao().Update(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            _conexao.ObterConexao().Delete(usuario);
        }

        public bool Validar(Usuario usuario)
        {
            Usuario validar = _conexao.ObterConexao().Table<Usuario>().Where(a => a.Login == usuario.Login).Where(a => a.Senha == usuario.Senha).FirstOrDefault();//Buscar usuário que atenda as exigências de Login e Senha

            if (validar != null)
                return true;
            else
                return false;
        }
    }
}
