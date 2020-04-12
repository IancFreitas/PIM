using System;
using System.Collections.Generic;
using System.Text;

namespace PIM.Funcionarios
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodigoFuncionario { get; set; }
        public string Cpf { get; set; }
        public string Funcao { get; set; }
        public int CodigoFuncao { get; set; }
    }
}
