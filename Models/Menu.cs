using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Menu
    {    
        public void Apresentacao()
        {
            Console.WriteLine("Bem vindo ao Gerenciador de Reservas!");
            Console.WriteLine("Made by: 👾 github.com/szaire 👾\n");
        }
        
        public void Interface()
        {
            Console.WriteLine("Digite a opção:");
            Console.WriteLine("[1] 💁 Gerenciar Lista de Hóspedes 💁");
            Console.WriteLine("[2] 🚪 Gerenciar Suite 🚪");
            Console.WriteLine("[3] ✅ Gerenciar Reserva ✅\n");
            Console.Write(">> ");
        }

        public void Pausa()
        {
            Console.WriteLine("Digite qualquer tecla...");
            Console.ReadKey();
        }

        public void TratamentoOpcoes(int option)
        {
            switch (option)
            {
                case 1:

            }
        }
    }
}