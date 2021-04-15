using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ENCar
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int precio;

        public string LicensePlate
        {
            get { return matricula; }
            private set { matricula = value; }
        }

        public string Brand
        {
            get { return marca; }
            private set { marca = value; }
        }

        public string Model
        {
            get { return modelo; }
            private set { modelo = value; }
        }

        public int Price
        {
            get { return precio; }
            private set { precio = value; }
        }

        public ENCar(string matricula, string marca, string modelo, int precio)
        {

        }

        public bool createCar()
        {

        }

        public bool deleteCar()
        {

        }

        //Solo hace falta updatear el precio? Porque el modelo y marca no se puede cambiar.
        public bool updatePriceCar(int precio)
        {

        }


    }
}
