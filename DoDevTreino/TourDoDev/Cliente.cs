using System;


public class Cliente
{
    //Atributos
    public string nomeCliente;
    public double cpf;
    public double telefone;
    public string email;    
    public double idade;
    public string endereco;

    //Métodos
    public void cadastroCliente()
    {
        Console.WriteLine("Digite seu nome: "+nomeCliente);
        Console.WriteLine("Digite seu cpf: "+cpf);
        Console.WriteLine("Digite seu telefone: "+telefone);
        Console.WriteLine("Digite seu e-mail: "+email);
        Console.WriteLine("Digite sua idade: "+idade);
        Console.WriteLine("Digite seu endereço: "+endereco);
    }
    //Se idade for menor de 18 >> Imprima, só vendemos para maiores de 18 anos.

}
