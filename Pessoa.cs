namespace ER7UC9
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public Endereco Localizacao { get; set; }
        public abstract double PagarImposto(float Salario);
    }
}