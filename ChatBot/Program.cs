﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagens bot = new Mensagens();
            bot.Iniciar();

            Console.ReadKey();
        }
    }
}
