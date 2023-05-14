using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Suite
    {
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
			TipoSuite = tipoSuite;
			Capacidade = capacidade;
			ValorDiaria = valorDiaria;
		}

        public string TipoSuite
        {
            get => _tipoSuite;
            set => _tipoSuite = value;
        }

        public int Capacidade
        {
            get => _capacidade;
            set => _capacidade = value;
        }
        
        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set => _valorDiaria = value;
        }   
    }
}