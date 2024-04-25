using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class VisitaTec
    {
        public void Executar()
        {
            Console.WriteLine("\nOk. Em até 48 horas um dos nossos técnicos irá fazer a visita técnica.");
            Console.WriteLine("Certifique-se que tenha uma pessoa em sua residência durante os nossos horário de atendimento (9h-18h).");
            Console.WriteLine("Além disso, nosso atendimento só será feito mediante a presença de um responsável maior de idade.");
            new Encerrar().Executar();
        }
    }

    public class ErroDados
    {
        public void Executar()
        {
            Console.WriteLine("Certo, parece que temos um erro com seus dados. \nEm um instante iremos te encaminhar para o atentimento com um dos nossos técnicos.");
        }
    }

    public class Encerrar
    {
        public void Executar()
        {
            Console.WriteLine("Encerramos então nosso atendimento. Tenha um ótimo dia.");
        }
    }

    public class Atendente
    {
        public void Executar()
        {
            Console.WriteLine("Ok. Aguarde alguns instante para que um dos nossos técnicos te atenda.");
        }
    }

    public static class Login
    {
        private static  string _nome;

        public static string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        private static string _end;

        public static string End
        {
            get { return _end; }
            set { _end = value.ToUpper(); }
        }

        public static string Cpf {  get; set; }

        public static void Executar()
        {
            Console.WriteLine("Olá. Você está no suporte online da Iluminado Fibra.");
            Console.WriteLine("Para começarmos, primeiro nos forneça algumas informações.");
            Console.Write("Digite seu nome completo: ");
            Nome = Console.ReadLine();
            Console.Write("Digite seu CPF: ");
            Cpf = Console.ReadLine();
            Console.Write("Digite seu endereço: ");
            End = Console.ReadLine();
        }
    }
}
