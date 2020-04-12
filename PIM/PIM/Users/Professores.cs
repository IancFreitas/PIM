using System;
using System.Collections.Generic;
using System.Text;
using PIM.Funcionarios;

namespace PIM.Professores
{
    class Professor : Funcionario
    {
        Professor professor1 = new Professor()
        {
            Nome = "Clayton",
            Cpf = "119.876.543-21",
            CodigoFuncionario = 201,
            Id = 21,
            Funcao = "Professor",
            CodigoFuncao = 2
        };

        Professor professor2 = new Professor()
        {
            Nome = "Fernanda",
            Cpf = "456.789.123-22",
            CodigoFuncionario = 202,
            Id = 22,
            Funcao = "Professor",
            CodigoFuncao = 2
        };
    }
}
