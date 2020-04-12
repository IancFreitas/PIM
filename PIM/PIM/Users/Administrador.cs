using System;
using System.Collections.Generic;
using System.Text;
using PIM.Funcionarios;

namespace PIM.Administradores
{
    class Administrador : Funcionario
    {
        Administrador administrador1 = new Administrador()
        {
            Nome = "Ian",
            Cpf = "123.456.789-11",
            CodigoFuncionario = 101,
            Id = 11,
            Funcao = "Desenvolvedor",
            CodigoFuncao = 1
        };

        Administrador administrador2 = new Administrador()
        {
            Nome = "Fernanda",
            Cpf = "456.789.123-22",
            CodigoFuncionario = 102,
            Id = 12,
            Funcao = "Diretora",
            CodigoFuncao = 1
        };
    }
}
