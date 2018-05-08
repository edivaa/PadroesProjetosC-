using System;
namespace PadroesProjetos.Classes.Padroes.Criacionais.Singleton
{
    public class ConexaoDB
    {
		//guarda internamente a intancia
		private static ConexaoDB _instance;

		private ConexaoDB(){}

        //método que retorna singleton
		public static ConexaoDB Instance()
		{

			//garantir que sempre uma instancia exista
			if (_instance == null)
			{
				_instance = new ConexaoDB();
			}

			return _instance;

		}


		public string stringConexao{ get; set; }
		public void Open(){
			Console.WriteLine("Abrindo Conexão "+stringConexao); 
		}

    }
}
