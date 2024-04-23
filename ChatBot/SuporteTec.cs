using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class SuporteTec
    {
        public string NomeCompleto {  get; set; }
        public string End {  get; set; }
        public string Cpf {  get; set; }

        public void ExecutarTec()
        {
            Console.WriteLine("Olá. Bem vindo ao suporte técnico online.");
            Console.WriteLine("Para começarmos, primeiro nos forneça algumas informações.");
            Console.Write("Digite seu nome completo: ");
            NomeCompleto = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            Cpf = Console.ReadLine();
            Console.Write("Digite seu endereço: ");
            End = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{this.NomeCompleto}, Escolha uma das opções abaixo.");
            Console.WriteLine("1: Minha internet não está funcionando.");
            Console.WriteLine("2: Meu roteador não liga.");
            Console.WriteLine("3: Desejo falar com um atendente da Iluminado Fibra.");
            Console.WriteLine("4: Sair");
            int esc = int.Parse( Console.ReadLine() );
            Console.Clear();

            switch ( esc )
            {
                case 1:
                    Console.WriteLine("Primeiro, tente reiniciar seu roteador ao menos 2 vezes.");
                    Console.WriteLine("Se o problema persistiu, digite Sim");
                    string resp = Console.ReadLine();
                    if (resp == "Sim" || resp == "sim")
                    {
                        Console.WriteLine("Certo. Iremos agendar um atendimento presencial de um técnico.");
                        Console.WriteLine($"Confirme seu endereço digitando sim: {this.End}");
                        string respEnd = Console.ReadLine();
                        if (respEnd == "Sim" || respEnd == "sim")
                        {
                            // new VisitaTec().Executar();
                        }
                        else
                        {
                            // new ErroDados().Executar();
                        }
                    }
                    else
                    {
                        // new Encerrar().Executar();
                    }
                    break;


                case 2:
                    Console.WriteLine("Certo. Primeiro verifique se todos os cabos estão conectatos de forma correta no roteador.");
                    Console.WriteLine("Além disso, também verifique se ele está devidamente ligado em uma tomada que funcione.");
                    Console.WriteLine("Caso você tenha feito tudo isso e ainda sim o problema persistiu, digite sim");
                    string resp2 = Console.ReadLine();
                    if (resp2 == "Sim" || resp2 == "sim")
                    {
                        Console.WriteLine("Certo. Iremos agendar um atendimento presencial de um técnico.");
                        Console.WriteLine($"Confirme seu endereço digitando sim: {this.End}");
                        string respEnd = Console.ReadLine();
                        if (respEnd == "Sim" || respEnd == "sim")
                        {
                            // new VisitaTec().Executar();
                        }
                        else
                        {
                            // new ErroDados().Executar();
                        }
                    }
                    else
                    {
                        // new Encerrar().Executar();
                    }
                    break;


                case 3:
                    // new Atendente().Executar(); 
                    break;


                case 4:
                    // new Sair().Executar();
                    break;
            }
        }
    }
}
