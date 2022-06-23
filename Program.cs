using Projeto_POO.Models;
using System;
class Program
{
    public static void Main(string[] args)

    {   
        /*Exercicio 3 Crie uma Classe Pessoa, contendo os atributos (nome,
        endereço e telefone) encapsulados, com seus respectivos seletores
        (getters) e modificadores (setters), e ainda o construtor padrão.
        Por fim, criar uma classe principal que instancie o objeto Pessoa, adicione
        no mínimo um valor para cada atributo e imprima na tela.*/
        Pessoa pessoa = new Pessoa();
        pessoa.SetNome("Darlan");
        pessoa.SetEndereco("Rua São Nicolau");
        pessoa.SetTelefone("51996107886");       
        Console.WriteLine($"Olá {pessoa.GetNome()} você mora na {pessoa.GetEndereco()} e seu telefone é {pessoa.GetTelefone()}");        
    }
}
