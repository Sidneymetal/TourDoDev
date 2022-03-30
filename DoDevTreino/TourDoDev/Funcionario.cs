using System;

class Funcionario
{   //Atributos
    public string nome;

    public double re;
    public string funcao;
    public string setor;
    //Métodos
    public void dadosFuncionario()
    {
        Console.WriteLine(nome);
        Console.WriteLine("RE: " +re);
        Console.WriteLine(funcao);
        Console.WriteLine("Setor: "+setor);
    }
}


//funcionário = nome, RE, função, setor.