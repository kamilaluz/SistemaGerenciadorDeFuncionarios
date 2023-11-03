using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarFuncionarios.Classes
{
    public abstract class Funcionarios : IFuncionarios
    {
        public string Nome;
        public int NumIdentificacao;
        public string DataNascimento;
        public string Cargo;
        public double Salario;
        public string Telefone;

        public Funcionarios(string nome, int numIdentificacao, string dataNascimento, string cargo, double salario, string telefone)
        {
            Nome = nome;
            NumIdentificacao = numIdentificacao;
            DataNascimento = dataNascimento;
            Cargo = cargo;
            Salario = salario;
            Telefone = telefone;
        }

        public abstract double ReajustarSalario();
        public abstract double CalcularPPR();
        public abstract void ExibirInformacoes();
    }
}
