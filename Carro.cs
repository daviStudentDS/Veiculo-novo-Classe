using Projeto_Veículo_AGLRN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Veiculo_AGLRN
{
       internal class Carro : Veiculo
    {
        private string carroceria;
        private object portamalas;
        private string portas;


        public Carro()
        {
            this.carroceria = null;
            this.portamalas = null;
            this.portas = null;
        }

        public string Carroceria
        {
            get { return this.carroceria; }
            set { this.carroceria = value; }
        }

        public string PortaMalas
        {
         
            get { return (string)this.portamalas; }
            set { this.portamalas = value; }
        }

        public string Portas
        {
            get { return this.portas; }
            set { this.portas = value; }
        }

        public Carro(string marca, string modelo, string combustivel, string chassi, string cambio, string motor, string carroceria, string portamalas, string portas)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Chassi = chassi;
            this.Cambio = cambio;
            this.Motor = motor;
            this.Carroceria = carroceria;
            this.PortaMalas = portamalas;
            this.Portas = portas;
        }

        public override String ImprimeDados()
        {
            String cad = String.Empty;
            cad = String.Concat($"{this.Marca}, {this.Modelo}, {this.Combustivel}, {this.Chassi}, {this.Cambio}, {this.Motor}, {this.Carroceria}, {this.PortaMalas}, {this.Portas}");
            return cad;
        }
    }
}
