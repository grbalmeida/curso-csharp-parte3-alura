﻿using ByteBank.Funcionarios;
using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }

            Console.WriteLine("Senha incorreta!");
            return false;
        }

        public bool Logar(GerenteDeConta funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }

            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}
