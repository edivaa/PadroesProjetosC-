using System;
using PadroesProjetos.Classes;
using PadroesProjetos.Classes.Objetos;
namespace PadroesProjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Herancas
            //Aluno aluno = new Aluno();
            //aluno.Nome = "Paulo";
            //aluno.Idade = 25;
            //aluno.Dormir();


            //Funcionario funcionario = new Funcionario();
            //funcionario.Nome = "Gilberto Santos";
            //funcionario.Idade = 29;
            //funcionario.Departamento = "Imóveis";
            //funcionario.trabalhar();


            //Polimorfismo
            //MeioTransporte carro = new Carro("Astra GSI");

            //carro.Ligar();
            //carro.Mover();
            //carro.Abastecer();
            //carro.Mover();

            //MeioTransporte aviao = new Aviao();
            //aviao.Marca = "Embrae";
            //aviao.Modelo = "F22";
            //aviao.Mover();



            //Class Abstracts
            NoteBook noteBook = new NoteBook("Acer aspire");

            noteBook.Porta1 = new Iphone();
            noteBook.Porta1.plugar();
            noteBook.Porta2 = new Teclado();
            noteBook.Porta2.plugar();
            noteBook.Porta3 = new Mouse();
            noteBook.Porta3.plugar();


            //Console.WriteLine("Hello World!");
        }
    }
}
