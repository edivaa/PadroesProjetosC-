using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadroesProjetos.Classes;
using PadroesProjetos.Classes.Objetos;
using PadroesProjetos.Classes.Padroes;
using PadroesProjetos.Classes.Padroes.Abstract_factory;
using PadroesProjetos.Classes.Padroes.Factory_method;

namespace PadroesProjetos.Classes.Outros
{
    class Estudo
    {
        delegate int Formula(int a, int b);
        delegate int FormulaOp(int a, int b=4, int c=7);
        delegate void delega(int x, string s);

        public void assuntosEstudados() {


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
            //NoteBook noteBook = new NoteBook("Acer aspire");
            //
            //noteBook.Porta1 = new Iphone();
            //noteBook.Porta1.plugar();
            //noteBook.Porta2 = new Teclado();
            //noteBook.Porta2.plugar();
            //noteBook.Porta3 = new Mouse();
            //noteBook.Porta3.plugar();

            //Interfaces
            //Arquivo doc = new Documento() { Descricao = "Artigo .net Magazine" };
            //MP3 musica = new MP3() { Descricao = "Dream Theater" };
            //Foto foto = new Foto { Descricao = "Palestra Delphi Conference" };

            //doc.abrir();
            //musica.abrir();

            //foto.abrir();
            //foto.Imprimir();

            //Delegacao
            //Gerente chefe = new Gerente();
            //chefe.Trabalhar("Sistema atendimento ao usuário");


            //Delegates

            //
            //Console.WriteLine("Resultado do calculo:" + Calcular(5, 7));
            //Formula op = (a, b) => (a + b) * 3;
            //Console.WriteLine(op(5,7));
            //FormulaOp op2 = (a, b, c) => (a + b) * 3 + c;
            //Console.WriteLine(op2(4, 6, 9));
            //Console.WriteLine(op2(4)); //Passando apenas um valor pois os outraos esta setados com default
            //Console.WriteLine(op2(4, 6));//Passando apenas dois valores

            //Console.WriteLine(op2(4, 6, 10));//Passando os tres valores novamente

            //Console.WriteLine(op2(4,c:8)); //Passando apenas valores de A e 

            //System.MulticastDelegate
            //delega d;

            //d = delegate (int idade, string nome)
            // {
            //     Console.WriteLine("A idade de {1} é {0}", idade, nome);
            // };
            //
            //d(19, "Maria");
            //d = MetodoComNome;
            //d(5, "Códigos Eficientes");


            //Implementacao de AbstractFactory
            //var db = new SQLFactory();// Fabrica concreta de SQL
            var db = new OracleFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();


            //Factory Method
            Creator[] creators = new Creator[2];
            creators[0] = new FacbookCreator();
            creators[1] = new GoogleCreator();
            foreach(Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance();
                aut.Autenticar();
            }

            Console.ReadLine();

        }   

        static int Calcular(int a, int b)
        {
            return (a + b) * 3;
        }


        static void MetodoComNome(int tempo, string canal)
        {
            Console.WriteLine("{0} anos de canal {1}", tempo, canal);
        }
    }
}
