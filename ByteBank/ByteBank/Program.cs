﻿using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879-157-20");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658-148-30");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        
        }
    }
}
