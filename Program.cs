namespace Banco
{    class Program
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
