using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao5 {
    internal class Concessionaria {

        private string _modelo;
        public string Marca { get; set; }
        public double Preco { get; private set; }

        public Concessionaria() { 
        }

        public Concessionaria(string marca, string modelo, double preco) {
            Marca = marca; 
            _modelo = modelo;
            Preco = preco; 
        }

        #region Getters e Setters
        /*public string Getmarca() {
            return _marca;
        }

        public string GetModelo() {
            return _modelo;
        }
        public double GetPreco() {
            return _preco;
        }

        public void SetPreco(double preco) {
            _preco = preco;
        }
        public void Setmarca(string marca) {
            _marca = marca;
        }

        public void SetModelo(string modelo) {
            _modelo = modelo;
        }*/
        #endregion

        #region Properties
/*        public string Marca {
            get { return _marca; }
            set { _marca = value; }
        }*/

        public string Modelo {
            get { return _modelo; }
            set { _modelo = value; }
        }

        /*public double Preco {
            get { return _preco; }
            set { _preco = value; }
        }*/
        #endregion


    }
}
