using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class SuporteFinanceiro
    {
        // Método para executar a opção de suporte financeiro
        public void ExecutarFinanceiro()
        {
            Console.WriteLine($"{Login.Nome}, Escolha uma das opções abaixo.");
            Console.WriteLine("1: Preciso da segunda via no meu bolheto.");
            Console.WriteLine("2: Consultar faturas em aberto.");
            Console.WriteLine("3: Negociar débitos.");
            Console.WriteLine("4: Desejo falar com um atendente da Iluminado Fibra.");
            Console.WriteLine("5: Sair");
            int esc = int.Parse( Console.ReadLine() );
            Console.Clear();

            switch ( esc )
            {
                case 1:
                    Console.WriteLine("Certo. Te encaminharemos uma segunda via de seu bolheto através do seu email cadastrado.");
                    Console.WriteLine($"Confirme seu email digitando sim: {Login.Email}");
                    string respEmail = Console.ReadLine();
                    if (respEmail == "Sim" || respEmail == "sim")
                    {
                        Console.WriteLine("\nOk, te encaminharemos o email e em seguida as instruções da alteração dentro de alguns instantes.");
                        Console.WriteLine("Caso tenha algum problema com o recebimento do email, peça parar falar com um dos nossos atendentes.");
                        new Encerrar().Executar();
                    }
                    else new ErroDados().Executar(); break;

                case 2:
                    Console.WriteLine("Certo, abaixo está o resumo de suas faturas em aberto");
                    Console.WriteLine(""); break; // Puxar da tabela as faturas em aberto

                case 3:
                    Console.WriteLine("OK, parece que você deseja negociar seus débitos em atraso.");
                    Console.WriteLine(""); break; // Nesse caso vamos pegar as informações das dívidas e e negociar

                case 4:
                    new Atendente().Executar(); break;

                case 5:
                    new Encerrar().Executar(); break;
            }
        }
    }
}
