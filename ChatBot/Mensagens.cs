using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
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
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1: Preciso de suporte técnico");
            Console.WriteLine("2: Preciso de suporte financeiro");
            Console.WriteLine("3: Sair");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    new SuporteTec().ExecutarTec(); break;
                case 2:
                    Console.WriteLine(); break; // Adicionar método Suporte Financeiro
                case 3:
                    Console.WriteLine(); break; // Adicionar método Saida
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    goto Inicio;
            }
        }
    }
}
