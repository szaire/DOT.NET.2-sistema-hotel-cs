using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Pessoa
    {
        private string? _nome;
        private string? _sobrenome;

        public Pessoa(string nome)
        {
			Nome = nome;
			Sobrenome = "";
		}

        public Pessoa(string nome, string sobrenome)
        {
			Nome = nome;
			Sobrenome = sobrenome;
		}

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string? Sobrenome
        {
			get => _sobrenome;
			set => _sobrenome = value;
        }

		public string GetNomeCompleto() => $"{Nome} {Sobrenome}".ToUpper();
	}
}