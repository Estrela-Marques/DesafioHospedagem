namespace DesafioHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite ?? throw new ArgumentNullException(nameof(tipoSuite));
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; } = string.Empty; 
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
