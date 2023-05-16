using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Reserva
    {
		List<Pessoa>? _hospedes;
		Suite? _suite;
		int _diasReservados;

        public Reserva(int diasReservados, Suite suite, List<Pessoa> hospedes)
        {
			DiasReservados = diasReservados;
			Suite = suite;
			Hospedes = hospedes;
		}

		// Propriedades

        public List<Pessoa> Hospedes
        {
			get => _hospedes;
			set => _hospedes = value;
		}

        public Suite Suite
        {
			get => _suite;
			set => _suite = value;
		}

        public int  DiasReservados
        {
			get => _diasReservados;
			set 
			{
				if (value <= 0)
				{
					_diasReservados = 0;
					throw new ArgumentException("Valores informados inválidos! Valores negativos ou nulos não são aceitos.");
				}
				_diasReservados = value;
			}
		}

		public void CadastrarHospedes(List<Pessoa> hospedes)
		{
			if (hospedes.Count <= Suite.Capacidade)
			{
				Hospedes = hospedes;
			}
			else
			{
				throw new ArgumentOutOfRangeException("A suíte não suporta a quantidade de hospedes informada!");
			}
		}

		public void CadastrarSuite(Suite s) => Suite = s;

		public int ObterQuantidadeHospedes() => Hospedes.Count;

		public decimal CalcularValorDiaria()
		{
			decimal valor = (DiasReservados * Suite.ValorDiaria);

			if (DiasReservados >= 10)
			{
				valor -= valor * 0.10M;
				return valor;
			}
			return valor;
		}
		
		// Métodos 
		// DONE: cadastrar hospedes (lista hospedes)
		// DONE: cadastrar suite (suite)
		// DONE: obter quantidade de hospedes
		// DONE: calcular valor da diaria
	}
}