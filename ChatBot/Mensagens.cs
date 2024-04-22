using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Mensagens
    {
        // Método para iniciar com as opções
        public void Iniciar()
        {
            // Em breve adicionar mais opções
            Inicio:
            Console.WriteLine("Olá. Você está no suporte online da Iluminado Fibra.");
            Console.WriteLine("Para começarmos, escolha uma das opções abaixo: ");
            Console.WriteLine("1: Preciso de suporte técnico");
            Console.WriteLine("2: Preciso de suporte financeiro");
            Console.WriteLine("3: Sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine(); // Adicionar método Suporte Técnico
                        break;
                case 2:
                    Console.WriteLine(); // Adicionar método Suporte Financeiro
                        break;
                case 3:
                    Console.WriteLine(); // Adicionar método Saida
                        break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    goto Inicio;
            }
        }
    }
}
