using GerenciarFuncionarios.Classes;

namespace GerenciarFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de gerenciamento de funcionários");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");
            Funcionarios[] funcionarios = new Funcionarios[3];

            for (int i = 0; i < funcionarios.Length; i++)
            {
                Console.WriteLine($"\nInforme o nome do {i + 1}º funcionário: ");
                string nome = Console.ReadLine();

                Console.WriteLine($"\nInforme o número de identificação do {i + 1}º funcionário: ");
                int numIdentificacao = int.Parse(Console.ReadLine());

                string dataNascimento = null;
                bool dataValida = false;
                while (!dataValida)
                {
                    Console.WriteLine($"\nInsira a data de nascimento do {i + 1}º funcionário (no formato dd/mm/aaaa): ");
                    dataNascimento = Console.ReadLine();
                    if (DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime novaDataNascimento))
                    {
                        dataValida = true;
                        Console.WriteLine("\nData de nascimento válida: " + novaDataNascimento.ToShortDateString());
                        Console.WriteLine($"Idade:  {DateTime.Now.Year - novaDataNascimento.Year} anos");
                    }
                    else
                    {
                        Console.WriteLine("Data de nascimento inválida. Certifique-se de usar o formato dd/mm/aaaa.");
                    }
                }

                Console.WriteLine($"\nInforme o cargo do {i + 1}º funcionário: ");
                string cargo = Console.ReadLine();

                Console.WriteLine($"\nInforme o salário do {i + 1}º funcionário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nInforme o número de telefone do {i + 1}º funcionário: ");
                string telefone = Console.ReadLine();

                Console.WriteLine("\nSelecione uma opção: ");
                Console.WriteLine("1 - Efetivo");
                Console.WriteLine("2 - Temporário");
                Console.WriteLine("3 - Estagiário");
                int opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        Funcionarios funcionario = new Efetivos(nome, numIdentificacao, dataNascimento, cargo, salario, telefone);
                        funcionarios[i] = funcionario;
                        break;
                    case 2:
                        funcionario = new Temporarios(nome, numIdentificacao, dataNascimento, cargo, salario, telefone);
                        funcionarios[i] = funcionario;
                        break;
                    case 3:
                        funcionario = new Estagiarios(nome, numIdentificacao, dataNascimento, cargo, salario, telefone);
                        funcionarios[i] = funcionario;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Digite um nome para consultar as informações: ");
            string procurado = Console.ReadLine();


            Funcionarios query = null;
            foreach (var funcionario in funcionarios)
            {
                if (procurado.ToLower() == funcionario.Nome.ToLower())
                {
                    query = funcionario;
                    break;
                }
            }
            if (query == null)
            {
                Console.WriteLine("Nome não encontrado!");
            }
            else
            {
                Console.WriteLine("Informações encontradas!");
                query.ExibirInformacoes();
            }
        }
    }
}