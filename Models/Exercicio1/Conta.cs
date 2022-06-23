namespace Projeto_POO.Models.Exercicio1
{
    public abstract class Conta
    {
        private int Numero { get; set; }
        private string Titular { get; set; }
        protected double Saldo { get; set; }


        
        public virtual double Rendimento ()
        {
            return Saldo;
        }
        public int GetNumero()
        {
            return Numero;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public string GetTitular()
        {
            return Titular;
        }
         public void SetTitular(string titular)
        {
            Titular = titular;
        }
        public double GetSaldo()
        {
            return Saldo;
        }
         public void SetSaldo(double saldo)
        {
            Saldo = saldo;
        }


    }
}