namespace Banco
{
    /// <summary>
    /// Classe abstrataa ContaBancariia
    /// </summary>
    public abstract class ContaBancaria
    {
        /// <summary>
        /// Atributo comum a todas as conta
        /// </summary>
        protected double saldo;
        /// <summary>
        /// Atributo para armazenar o nome do titular da conta(as meninas)
        /// </summary>
        protected string nome;
        /// <summary>
        /// Construtor que recebe o saldo inicial e o nome do titular
        /// </summary>
        /// <param name="saldoInicial"></param>
        /// <param name="nome"></param>
        public ContaBancaria(double saldoInicial, string nome)
        {
            saldo = saldoInicial;
            this.nome = nome;
        }

        /// <summary>
        /// Método abstrato para mostrar o extrato da conta
        /// </summary>
        public abstract void MostrarExtrato();
        /// <summary>
        /// Construtor que recebe o saldo inicial e o nome do titular
        /// </summary>
        /// <param name="valor"></param>
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Depósito de {0:C} realizado com sucesso.", valor);
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito.");
            }
        }
        /// <summary>
        /// Método virtual para sacar um valor da conta
        /// </summary>
        /// <param name="valor"></param>        
        public virtual void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque de {0:C} realizado com sucesso.", valor);
            }
            else
            {
                Console.WriteLine("Valor inválido ou insuficiente para saque.");
            }
        }
    }

}
