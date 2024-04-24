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
}
