using System;
namespace PadroesProjetos.Classes.Objetos
{
    public class MeioTransporte
    {
        protected string Marca;
        protected string Modelo;
        protected Motor _motor;
        protected Bateria _bateria;
        public int NUmPneus;


        public string marca(){
            return Marca;
        }

        public string modelo(){
            return Modelo;
        }
        public virtual void Mover(){}
        public virtual void Ligar(){}
        public virtual void Desligar(){}
        public virtual void Abastecer(){}

    }
}
