namespace Projeto_POO.Models.Exercicio1
{
    public class ContaCorrente : Conta
    {
        public override double Rendimento ()
        {
            return Saldo*0.03;
        }
    }
}