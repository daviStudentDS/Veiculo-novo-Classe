using System;
using Projeto_Veículo_AGLRN;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoVeiculo
{
    public class Caminhao : Veiculo
    {
        private string eixo;
        private string carga;
        private string cabine;


        public string Eixo
        {
            get { return eixo; }
            set { eixo = value; }
        }

        public string Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public string Cabine
        {
            get { return cabine; }
            set { cabine = value; }
        }

        public Caminhao(string marca, string modelo, string combustivel, string chassi, string cambio, string motor, string eixo, string carga, string cabine)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Chassi = chassi;
            this.Cambio = cambio;
            this.Motor = chassi;
            this.Eixo = eixo;
            this.Carga = carga;
            this.Cabine = cabine;
        }

        public override String ImprimeDados()
        {
            String cad = String.Empty;
            cad = String.Concat($"{this.Combustivel}, {this.Marca}, {this.Modelo}, {this.Combustivel}, {this.Chassi}, {this.Cambio}, {this.Motor}, {this.Eixo}, {this.Carga}, {this.Cabine}");
            return cad;
        }
    }
}
