using System.Text;
using System.Globalization;
using Sistema.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
		Console.OutputEncoding = Encoding.UTF8;
		Console.Clear();

		// DONE: código a ser implementado
		List<Pessoa> hospedes = new List<Pessoa>();
		hospedes.Add(new Pessoa("Samuel", "Zaire"));
		hospedes.Add(new Pessoa("Pedro", "Quinhas"));
		hospedes.Add(new Pessoa("Batavere", "Lazare"));
		hospedes.Add(new Pessoa("Fonsuaica", "Chan"));

		Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 200.00M);

		Reserva reserva = new Reserva(10);
		reserva.CadastrarSuite(suite);
		reserva.CadastrarHospedes(hospedes);

		Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
		Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
	}
}