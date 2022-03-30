using System;

namespace DoDevTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à TourDoDev \n");
            Console.WriteLine("Somos uma empresa de Turismo com os melhores pacotes de viagens. \n ");
            Console.WriteLine("Digite seus dados\n");
            
            Cliente cliente = new Cliente();
            cliente.nomeCliente = (Console.ReadLine());
            Cliente cpff = new Cliente();
            cpff.cpf = (Console.ReadLine());
            Cliente tel = new Cliente();
            tel.telefone = (Console.ReadLine());
            Cliente emaill = new Cliente();
            emaill.email = (Console.ReadLine());
            Cliente id = new Cliente();
            id.idade = (Console.ReadLine());
            Cliente end = new Cliente();
            end.endereco = (Console.ReadLine());

            

            //Funcionário 
            Console.WriteLine("Funcionario responsável pelo atendimento: \n");
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Sidney";
            funcionario.re = 188291;
            funcionario.funcao = "Atendente";
            funcionario.setor = "A012-Balcão 12";
            funcionario.dadosFuncionario();

        }
    }
}
//Instanciar

//Funcionário ok

