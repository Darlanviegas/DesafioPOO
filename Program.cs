using Projeto_POO.Models.Exercicio3;
using Projeto_POO.Models.Exercicio1;
using System;
class Program
{
    public static void Main(string[] args)

    {   /*Exercicio 1 Considerando os conceitos de Orientação a Objetos, crie
        uma classe abstrata Pai de nome Conta com os seguintes atributos
        (número, titular e saldo) e mais duas classes Filhas (ContaCorrente e
        ContaPoupanca). Na classe Conta deve existir um método de nome
        rendimento que retorna o rendimento mensal da conta, nas classes filhas
        deve existir o mesmo método rendimento, porém com as seguintes regras:*/

        Conta contacorrente = new ContaCorrente();
        contacorrente.SetNumero(1205);
        contacorrente.SetTitular("Darlan");
        contacorrente.SetSaldo(20000);
        contacorrente.Rendimento();
        Console.WriteLine($"Olá o numero da sua conta é {contacorrente.GetNumero()} o proprietário é {contacorrente.GetTitular()} seu saldo é {contacorrente.GetSaldo()} e seu rendimento foi {contacorrente.Rendimento()}");

        Conta contapoupanca = new ContaPoupanca();
        contapoupanca.SetNumero(1406);
        contapoupanca.SetTitular("Pedro");
        contapoupanca.SetSaldo(15200);
        contapoupanca.Rendimento();
        Console.WriteLine($"Olá o numero da sua conta é {contapoupanca.GetNumero()} o proprietário é {contapoupanca.GetTitular()} seu saldo é {contapoupanca.GetSaldo()} e seu rendimento foi {contapoupanca.Rendimento()}");
        Console.WriteLine();

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
