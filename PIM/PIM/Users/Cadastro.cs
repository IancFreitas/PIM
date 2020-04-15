using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PIM.Funcionarios;
using PIM.ListadeFuncionarios;

namespace PIM.Cadastros
{
    public class Cadastro : Funcionario
    {
        public bool TentativaAcesso(int codigo)
        {
            if (codigo == 1)
            {
                Console.WriteLine("Você possuí acesso para cadastro de Funcionário.");
                return true;
            }
            else
            {
                Console.WriteLine("Você não possuí acesso para cadastro. Entrar em contato com o Administrador.");
                return false;
            }
        }

        public bool Login(string Usuario, string Senha) 
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario == Usuario && x.Senha == Senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario != Usuario && x.Senha != Senha))
            {
                Funcionario cadastramento = new Funcionario();
                usuarios.Add(cadastramento);
                return true;
            }
            else
            {
                Console.WriteLine("Esse funcionário já existe");
                return false;
            }

        }
        public bool Retirar(string usuario)
        {
            var usuarios = BasedeDadosFuncionarios.CorpoDocente;
            if (usuarios.Any(x => x.Usuario != Usuario))
            {
                Funcionario cadastramento = new Funcionario();
                usuarios.Remove(cadastramento);
                return true;
            }
            else
            {
                Console.WriteLine("Esse funcionário não existe");
                return false;
            }

        }

    }
}
