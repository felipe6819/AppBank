using System;

namespace Banco
{
    // Classe abstrataa ContaBancariia
    public abstract class ContaBancaria
    {
        // Atributo comum a todas as conta
        protected double saldo;
        // Atributo para armazenar o nome do titular da conta(as meninas)
        protected string nome;
        // Construtor que recebe o saldo inicial e o nome do titular
        public ContaBancaria(double saldoInicial, string nome)
        {
            saldo = saldoInicial;
            this.nome = nome;
        }

        // Método abstrato para mostrar o extrato da conta
        public abstract void MostrarExtrato();
        // Método comum para depositar um valor na conta
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
        // Método virtual para sacar um valor da conta
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
    // Classe derivada ContaCorrente
    public class ContaCorrente : ContaBancaria
    {
        // Atributo específico da conta corrente
        private readonly double limite;
        // Construtor que recebe o saldo inicial, o limite e o nome do titular da conta corrente
        public ContaCorrente(double saldoInicial, double limite, string nome) : base(saldoInicial, nome)
        {
            this.limite = limite;
        }
        // Método para mostrar o extrato da conta corrente
        public override void MostrarExtrato()
        {
            Console.WriteLine("Conta Corrente");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Saldo: {0:C}", saldo);
            Console.WriteLine("Limite: {0:C}", limite);
            Console.WriteLine();
        }
    }
    // Classe derivada ContaPoupanca
    public class ContaPoupanca : ContaBancaria
    {
        // Atributo específico da conta poupança
        private readonly double rendimento;
        // Construtor que recebe o saldo inicial, o rendimento e o nome do titular da conta poupança
        public ContaPoupanca(double saldoInicial, double rendimento, string nome) : base(saldoInicial, nome)
        {
            this.rendimento = rendimento;
        }
        // Método para mostrar o extrato da conta poupança
        public override void MostrarExtrato()
        {
            Console.WriteLine("Conta Poupança");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Saldo: {0:C}", saldo);
            Console.WriteLine("Rendimento: {0:P}", rendimento);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Criando algumas contas bancárias com diferentes nomes e valores iniciais
            ContaBancaria c1 = new ContaCorrente(1000, 500, "Fernanda"); // pessoa física
            ContaBancaria c2 = new ContaPoupanca(2000, 0.01, "Clara"); // pessoa física
            ContaBancaria c3 = new ContaCorrente(3000, 1000, "Sofia"); // pessoa jurídica

            // Mostrando os extratos das contas criadas
            c1.MostrarExtrato();
            c2.MostrarExtrato();
            c3.MostrarExtrato();

            // Realizando algumas operações nas contas
            c1.Depositar(500);
            c2.Sacar(100);
            c3.Depositar(1000);

            // Mostrando os extratos das contas após as operações
            c1.MostrarExtrato();
            c2.MostrarExtrato();
            c3.MostrarExtrato();
            Console.WriteLine("ENTENSE? NÃO?!");

            Console.ReadLine();
        }
    }
}
