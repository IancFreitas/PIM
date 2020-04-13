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
        public bool TentativaAcesso()
        {
            int x = CodigoFuncao;

            if (x == 1)
            {
                Console.WriteLine("Você possuí acesso para cadastro de Funcionário. Por favor, insira os dados do mesmo.");
                return true;
            }
            else
            {
                Console.WriteLine("Você não possuí acesso para cadastro. Entrar em contato com o Administrador.");
                return false;
            }
        }

        public static bool Login(List<Funcionario> usuarios, string Usuario, string Senha) 
        {
            if (usuarios.Any(x => x.Usuario == Usuario && x.Senha == Senha))
            {
                Console.WriteLine("Seja bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Desculpa, você não é funcionário! Entre em contato com os Administradores.");
                return false;
            }
        }

    }
}
