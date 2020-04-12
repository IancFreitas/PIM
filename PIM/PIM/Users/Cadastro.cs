using System;
using System.Collections.Generic;
using System.Text;
using PIM.Funcionarios;

namespace PIM
{
    class Cadastro : Funcionario
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


    }
}
