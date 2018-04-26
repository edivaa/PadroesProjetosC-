using System;
using PadroesProjetos.Classes;
using PadroesProjetos.Classes.Objetos;
namespace PadroesProjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Aluno aluno = new Aluno();
            //aluno.Nome = "Paulo";
            //aluno.Idade = 25;
            //aluno.Dormir();


            //Funcionario funcionario = new Funcionario();
            //funcionario.Nome = "Gilberto Santos";
            //funcionario.Idade = 29;
            //funcionario.Departamento = "Imóveis";
            //funcionario.trabalhar();


            MeioTransporte carro = new Carro("Astra GSI");

            carro.Ligar();
            carro.Mover();
            carro.Abastecer();
            carro.Mover();

            //MeioTransporte aviao = new Aviao();
            //aviao.Marca = "Embrae";
            //aviao.Modelo = "F22";
            //aviao.Mover();

            //Console.WriteLine("Hello World!");
        }
    }
}
