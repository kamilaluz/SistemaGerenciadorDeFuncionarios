using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionarios.Classes
{
    public class Estagiarios : Funcionarios
    {
        public Estagiarios(string nome, int numIdentificacao, string dataNascimento, string cargo, double salario, string telefone) : base(nome, numIdentificacao, dataNascimento, cargo, salario, telefone) { }

        public override double ReajustarSalario()
        {
            return Salario + (Salario * 0.05);
        }

        public override double CalcularPPR()
        {
            return 0.5 * Salario;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou {Cargo} no Senai, trabalho como Estagiário(a).");
            Console.WriteLine($"Eu espero logo ser contratado(a) como efetivo(a).");
            Console.WriteLine($"Reajuste Salarial: R$ {ReajustarSalario().ToString("C")}");
            Console.WriteLine($"PPR: R$ {CalcularPPR().ToString("C")}");
        }
    }
}
