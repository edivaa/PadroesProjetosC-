using System;
namespace PadroesProjetos.Classes
{
    public class Funcionario : Pessoa
    {
        public string Departamento { get; set; }

        public void trabalhar()
        {
            Console.WriteLine(Nome + " trabalhanado ...");
        }

    }



    public class Estagiario : Pessoa
    {

        public void trabalhar(string tarefa)
        {
            Console.WriteLine(Nome + " trabalhando ...");
        }
    }


    public class Developer : Funcionario{

        public void trabalhar(string tarefa)
        {
            Console.WriteLine(Nome+" Programando ...");
        }
    }
    public class ArquitetoSoftware : Funcionario
    {

        public void trabalhar(string tarefa)
        {
            Console.WriteLine(Nome+" projetando ...");
        }
    }


    public class Tester : Funcionario{

        public void Testar(string tarefa){

            Console.WriteLine(Nome+" testando ...");  
        }
    }

    public class Gerente{

        private  Estagiario _estagiario;
        private  Developer _developer;
        private  ArquitetoSoftware _arquitetoSoftware;
        private  Tester _tester; 


        public Gerente(){

            _estagiario = new Estagiario();
            _estagiario.Nome = "Estagiário Antonio";
            _developer = new Developer();
            _developer.Nome = "Desenvolvedor Paulo";
            _arquitetoSoftware = new ArquitetoSoftware();
            _arquitetoSoftware.Nome = "Arquiteto Luis";
            _tester = new Tester();
            _tester.Nome = "Testador João";
        }


        public void Trabalhar(string tarefa){

            Console.WriteLine("Gerente recebeu a tarefea" + tarefa);

            _estagiario.trabalhar(tarefa);
            _arquitetoSoftware.trabalhar(tarefa);
            _developer.trabalhar(tarefa);
            _tester.Testar(tarefa);



        }
    }
}
