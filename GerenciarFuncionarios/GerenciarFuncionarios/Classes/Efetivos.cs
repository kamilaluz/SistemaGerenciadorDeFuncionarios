using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionarios.Classes
{
    internal class Efetivos : Funcionarios
    {
        public Efetivos(string nome, int numIdentificacao, string dataNascimento, string cargo, double salario, string telefone) : base(nome, numIdentificacao, dataNascimento, cargo, salario, telefone) { }

        public override double ReajustarSalario()
        {
            return Salario + (Salario * 0.1);
        }

        public override double CalcularPPR()
        {
            return 2 * Salario;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou {Cargo} no Senai, trabalho como funcionário(a) Efetivo(a).");
            Console.WriteLine($"Reajuste Salarial: R$ {ReajustarSalario().ToString("C")}");
            Console.WriteLine($"PPR: R$ {CalcularPPR().ToString("C")}");
        }
    }
}
