namespace Banco
{
    /// <summary>
    /// Classe derivada ContaPoupanca
    /// </summary>    
    public class ContaPoupanca : ContaBancaria
    {
        /// <summary>
        /// Atributo específico da conta poupança
        /// </summary>        
        private readonly double rendimento;

        /// <summary>
        /// Construtor que recebe o saldo inicial, o rendimento e o nome do titular da conta poupança
        /// </summary>
        /// <param name="saldoInicial"></param>
        /// <param name="rendimento"></param>
        /// <param name="nome"></param>
        public ContaPoupanca(double saldoInicial, double rendimento, string nome) : base(saldoInicial, nome)
        {
            this.rendimento = rendimento;
        }
        /// <summary>
        ///  Método para mostrar o extrato da conta poupança
        /// </summary>
        public override void MostrarExtrato()
        {
            Console.WriteLine("Conta Poupança");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Saldo: {0:C}", saldo);
            Console.WriteLine("Rendimento: {0:P}", rendimento);
            Console.WriteLine();
        }
    }
}
