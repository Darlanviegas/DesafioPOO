namespace Projeto_POO.Models.Exercicio4
{
    public class Carro
    {
        public Carro()
        {
            this.Modelo = "";
            this.Marca = "";
        }

        public Carro(string modelo, string marca,string tipocombustivel)
        {
            this.Modelo = modelo;
            this.Marca = marca; 
            this.TipoCombustivel = tipocombustivel; 
                      
        }
        public string Modelo { get; set; }
        public string Marca { get; set; }   
        public string TipoCombustivel { get; set; }     

        public virtual string GetModelo()
        {
            return Modelo;
        }
        public virtual void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public virtual string GetMarca()
        {
            return Marca;
        }
        public virtual void SetMarca(string marca)
        {
            Marca = marca;
        }     
        public virtual string GetTipoCombustivel()
        {
            return TipoCombustivel;
        }
        public virtual void SetCombustivel(string tipocombustivel)
        {
            TipoCombustivel = tipocombustivel;
        }   

    }
}