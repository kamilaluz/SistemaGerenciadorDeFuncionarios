using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionarios.Classes
{
    public class Temporarios : Funcionarios
    {
        public Temporarios(string nome, int numIdentificacao, string dataNascimento, string cargo, double salario, string telefone) : base(nome, numIdentificacao, dataNascimento, cargo, salario, telefone) { }

        public override double ReajustarSalario()
        {
            return Salario + (Salario * 0.07);
        }

        public override double CalcularPPR()
        {
            return Salario;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou {Cargo} no Senai, trabalho como funcionário(a) Temporário(a).");
            Console.WriteLine($"Eu quero ser efetivo(a) nessa empresa porque ela é muito boa para trabalhar.");
            Console.WriteLine($"Reajuste Salarial: R$ {ReajustarSalario().ToString("C")}");
            Console.WriteLine($"PPR: R$ {CalcularPPR().ToString("C")}");
        }
    }
}
