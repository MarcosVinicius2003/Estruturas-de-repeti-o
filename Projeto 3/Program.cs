﻿using System;

namespace Projeto_3
{
    class Program
    {
    
        static void Main(string[] args)
        {   
            
            string nome;
            int idade;
            float salario;
            string estadoCivil;
            do{
                Console.WriteLine("Insira seu Nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Insira sua Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Salario:");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Estado Civil: s - Solteiro; c - Casado; v - Viuvo; d - Divorciada");
                estadoCivil = (Console.ReadLine());

                if(nome == ""){Console.WriteLine("Insira um nome valido"); nome = "null";}

                if(idade < 0 || idade >150){ Console.WriteLine("Insira uma idade valido"); idade = 1;}

                if(salario == 0){ Console.WriteLine("Insira um salario valido"); salario = 0;}

                if(estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d"){}
                
                else{
                    Console.WriteLine("Insira um estado civil valido");
                    estadoCivil = "";
                }
            }while(nome == "" || idade == 1 || salario == 0 || estadoCivil == "" );

            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estadoCivil);

            Console.WriteLine("Perfil Verificado");
        }
    }
}