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

		Menu menu = new Menu();

		menu.Apresentacao();
		Console.Write("Digite o valor da diária: ");
		decimal valorDiaria = Convert.ToInt32(Console.Read());
		menu.Pausa();

		int option;
		do
		{
			Console.Clear();

			menu.Interface();
			option = Convert.ToInt32(Console.Read());
			menu.TratamentoOpcoes(option);

		} while (option != 4);


		// DONE: código a ser implementado
		List<Pessoa> hospedes = new List<Pessoa>();

		//hospedes.Add(new Pessoa("Samuel", "Zaire"));
		//hospedes.Add(new Pessoa("Pedro", "Quinhas"));
		//hospedes.Add(new Pessoa("Batavere", "Lazare"));
		////hospedes.Add(new Pessoa("Fonsuaica", "Chan"));

		Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 200.00M);
		//Reserva reserva = new Reserva(10, suite, hospedes);

		List<Reserva> reservas = new List<Reserva>();
		//reservas.Add(reserva);

		//Gerenciador.WriteFile(reservas, "resources");
	} 
}