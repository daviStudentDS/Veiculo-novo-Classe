using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veículo_AGLRN
{
    public abstract class Veiculo
    {
        private string marca;
        private string modelo;
        private string combustivel;
        private string chassi;
        private string cambio;
        private string motor;

        public Veiculo()
        {
            this.marca = null;
            this.modelo = null;
            this.combustivel = null;
            this.chassi = null;
            this.cambio = null;
            this.motor = null;
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.modelo = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public string Combustivel
        {
            get { return this.combustivel; }
            set { this.combustivel = value; }
        }

        public string Chassi
        {
            get { return this.chassi; }
            set { this.chassi = value; }
        }

        public string Cambio
        {
            get { return this.cambio; }
            set { this.cambio = value; }
        }

        public string Motor
        {
            get { return this.motor; }
            set { this.motor = value; }
        }

        public abstract String ImprimeDados();
    }
}
