namespace Projeto_POO.Models.Exercicio4
{
    public class Uno:Carro
    {           
        public void ExibirInfo()
        {
            Console.WriteLine($"Esse é o {Modelo} fabricado pela {Marca} movido a {TipoCombustivel}");
        }
    }
}