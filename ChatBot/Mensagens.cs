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
            Login.Executar();
            Console.WriteLine($"\n{Login.Nome}, Escolha uma das opções abaixo.");
            Console.WriteLine("1: Preciso de suporte técnico.");
            Console.WriteLine("2: Preciso de suporte financeiro.");
            Console.WriteLine("3: Quero falar com um atendente.");
            Console.WriteLine("4: Sair.");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    new SuporteTec().ExecutarTec(); break;
                case 2:
                    Console.WriteLine(); break; // Adicionar método Suporte Financeiro
                case 3:
                    new Atendente().Executar(); break;
                case 4:
                    new Encerrar().Executar(); break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    goto Inicio;
            }
        }
    }
}
