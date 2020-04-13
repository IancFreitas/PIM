using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PIM.ListadeEquipamentos;
using PIM.ListadeFuncionarios;
using PIM.ListadeSalas;
using PIM.Cadastros;
using PIM.Funcionarios;
using PIM.Alugar;

namespace PIM
{
    public class Program
    {
        private void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de agendamento do Colégio Vencer Sempre");
            Console.WriteLine(" ");
            Console.WriteLine("Informe o seu usuario: ");
            Console.WriteLine(" ");
            string user = Console.ReadLine();
            Console.WriteLine("Informe a sua senha: ");
            Console.WriteLine(" ");
            string password = Console.ReadLine();
            //bool log = Login(user, password);
            //tentar fazer o login funcionar
            Console.WriteLine("O que deseja fazer? 1 - Reservar Sala 2 - Reservar Equipamento 3 - Devolver Sala 4 - Devolver Equipamento 5 - Cadastrar novo funcionário 6 - Sair");
            int resposta1 = int.Parse(Console.ReadLine());
            switch (resposta1)
            {
                case 1:
                    if(BasedeDadosSalas.SalasLiberadas() >= 1)
                    {
                        //continuar
                    }
            }



        }

    }
}
