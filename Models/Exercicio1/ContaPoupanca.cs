namespace Projeto_POO.Models.Exercicio1
{
    public class ContaPoupanca : Conta
    {
        public override double Rendimento ()
        {
            return Saldo*0.05;
        }
    }
}