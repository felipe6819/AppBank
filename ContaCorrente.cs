namespace Banco
{

    /// <summary>
    /// Classe derivada ContaCorrente
    /// </summary>

    public class ContaCorrente : ContaBancaria
    {
        /// <summary>
        /// Atributo específico da conta corrente
        /// </summary>        
        private readonly double limite;
        /// <summary>
        /// Construtor que recebe o saldo inicial, o limite e o nome do titular da conta corrente
        /// </summary>
        /// <param name="saldoInicial"></param>
        /// <param name="limite"></param>
        /// <param name="nome"></param>
        public ContaCorrente(double saldoInicial, double limite, string nome) : base(saldoInicial, nome)
        {
            this.limite = limite;
        }
        /// <summary>
        /// étodo para mostrar o extrato da conta corrente
        /// </summary>
        public override void MostrarExtrato()
        {
            Console.WriteLine("Conta Corrente");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Saldo: {0:C}", saldo);
            Console.WriteLine("Limite: {0:C}", limite);
            Console.WriteLine();
        }
    }
}